using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;

#region Helper Classes
[System.Serializable]

//Dynamic Textboxes for each character that tracks the moods and typing speed
public class CharacterDialogueUI
{
public string characterName;

[Header("Dialogue Box")]
public GameObject dialogueBoxRoot;
public TextMeshProUGUI dialogueText;

[Header("Border Character (Circled Image)")] //Do NOT confuse this with the mood sprite, this is the character PFP
public Image characterPfp;

[Header("Typing")]
public float typingSpeed = 0.02f;

[Header("Controls")]
public Button nextButton;
public Button skipButton;

[Header("Sound")]
public AudioClip[] typingSounds;
[Range(0f, 1f)] public float typingVolume = 0.4f;
public float soundDelay = 0.05f; // controls how often sounds play
}
#endregion

//Actual dialogue manager code below, including all inspector set up items
public class DialogueManager : MonoBehaviour
{
[Header("Ink")]
private Story story; //the actual inky story instance
public TextAsset inkJSON; // Assign the Ink JSON file for this scene in the inspector (TESTING ONLY)

[Header("Ink Start")]
[Tooltip("Set the starting knot for this scene")]
public string startingKnot; // inspector-defined per scene

[Header("Characters")]
public List<CharacterDialogueUI> characters; //dictionary of all character that have speaking lines in the scene dialouge
private Dictionary<string, CharacterDialogueUI> lookup; //allow for set up of one character that can be reused again 
private CharacterDialogueUI currentCharacter; //current speaking character

[Header("Choices")]
public GameObject choicePanel;
public Transform choiceContainer;
public Button choicePrefab;

[Header("Skip UI")]
public GameObject skipSummaryPanel;
public TextMeshProUGUI skipSummaryText;

[Header("Sound")]
public SoundFXManager soundFXManager;

private bool isTyping;
private bool skipLocked;
private bool isSkipping;
private bool isDialoguePlaying;
private float soundTimer = 0f;

private string currentLine;
private Coroutine typingCoroutine;
private List<string> skippedLines = new List<string>();

public static DialogueManager Instance { get; private set; }

void Awake()
{
    if (Instance != null && Instance != this)
    {
        Destroy(gameObject); // prevent duplicates
        return;
    }

    Instance = this;
    DontDestroyOnLoad(gameObject); //make sure it doesn't destory the relationship tracker
}

public void StartDialogue(string knotName)
{
    isDialoguePlaying = true;

    story.ChoosePathString(knotName);
    ContinueStory();
}

//Start inky file
void Start()
{
    if (inkJSON == null)
    {
        Debug.LogError("No Ink JSON assigned to DialogueManager for this scene!");
        return;
    }

    // Initialize a fresh Story instance from this scene's Ink file
    story = new Story(inkJSON.text);

    // Setup character lookup
    choicePanel.SetActive(false);
    lookup = new Dictionary<string, CharacterDialogueUI>();

    foreach (var c in characters)
    {
        lookup.Add(c.characterName, c);
        c.dialogueBoxRoot.SetActive(false);

        if (c.nextButton != null)
            c.nextButton.onClick.RemoveAllListeners();

        if (c.skipButton != null)
            c.skipButton.onClick.RemoveAllListeners();
    }

    if (!string.IsNullOrEmpty(startingKnot))
        StartDialogue(startingKnot);

    // Start dialogue if starting knot is set
    if (!string.IsNullOrEmpty(startingKnot))
    {
        StartDialogue(startingKnot);
    }
    else
    {
        Debug.LogWarning("No starting knot defined in DialogueManager for this scene.");
    }
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Return))
    {
        OnNextPressed();
    }
}

//Check tags to see if text is allowed to be skipped or not, controls how much of the story should flow and if there are any tags stopping the flow
void ContinueStory()
{

    // Only proceed if the story has content
    if (story.canContinue)
    {
        string text = story.Continue().Trim();  // Get the next piece of text
        HandleTags(story.currentTags);         // Activate speaker, skip tags, etc.

        // If there’s text to show
        if (!string.IsNullOrEmpty(text))
        {
            StartTyping(text);                  // Show it in dialogue box
            RefreshButtons();                   // Show next/skip buttons for currentCharacter
            return;                             // Stop here so only one line shows
        }
    }

    // If there are player choices
    if (story.currentChoices.Count > 0)
    {
        DisplayChoices(); // buttons hidden inside DisplayChoices
        return;
    }

    // Otherwise, end of knot
    CloseAllDialogueBoxes();
    choicePanel.SetActive(false);

    isDialoguePlaying = false;
}

//Master list of all tags currently in the ink file (DOUBLE CHECK THIS LATER MIGHT UPDATE WITH MORE DO NOT FORGET)
void HandleTags(List<string> tags)
{
    foreach (string tag in tags)
    {
        if (tag.StartsWith("speaker:"))
        {
            string speaker = tag.Split(':')[1].Trim();
            ActivateCharacter(speaker);
        }
        else if (tag.StartsWith("ending:"))
        {
            // Extract the name from the tag
            string sceneName = tag.Split(':')[1].Trim();
            SceneManager.LoadScene(sceneName);
        }
        else if (tag == "noskip_start")
        {
            skipLocked = true;
            UpdateSkipButton(); // grey out skip button
        }
        else if (tag == "noskip_end")
        {
            skipLocked = false;
            UpdateSkipButton(); // re-enable skip button
        }
        else if (tag.StartsWith("rel:"))
        {
            // Format: rel:CharacterName+1 or rel:CharacterName-1
            string data = tag.Substring(4); // remove "rel:"
            string character = data.Substring(0, data.Length - 2); // get name
            string op = data.Substring(data.Length - 2); // get +1 or -1

            if (op.StartsWith("+"))
            {
                int val = int.Parse(op.Substring(1));
                if (character == "C_Alice") RelationshipTracker.C_Alice += val;
                if (character == "A_Cheshire") RelationshipTracker.A_Cheshire += val;
                if (character == "A_MadMarch") RelationshipTracker.A_MadMarch += val;
                if (character == "A_WhiteRabbit") RelationshipTracker.A_WhiteRabbit += val;
                if (character == "C_RedQueen") RelationshipTracker.C_RedQueen += val;
            }
            else if (op.StartsWith("-"))
            {
                int val = int.Parse(op.Substring(1));
                if (character == "C_Alice") RelationshipTracker.C_Alice -= val;
                if (character == "A_Cheshire") RelationshipTracker.A_Cheshire -= val;
                if (character == "A_MadMarch") RelationshipTracker.A_MadMarch -= val;
                if (character == "A_WhiteRabbit") RelationshipTracker.A_WhiteRabbit -= val;
                if (character == "C_RedQueen") RelationshipTracker.C_RedQueen -= val;

            }
        }
    }
}

    // Updates the skip button so it greys out if skipping is not allowed
    private void UpdateSkipButton()
    {
        if (currentCharacter != null && currentCharacter.skipButton != null)
        {
            currentCharacter.skipButton.interactable = !skipLocked;
        }
    }

    //Used to control movement to the next dialogue box
    public void OnNextPressed()
    {
        if (isTyping)
        {
            FinishTyping();
            return;
        }

        if (story.currentChoices.Count > 0)
        {
            DisplayChoices();
            return;
        }

        ContinueStory();
    }

    //Check for the active character and display they're correct box, destory any remaining boxes in the scene
    void ActivateCharacter(string speaker)
    {
        foreach (var c in characters)
        {
            c.dialogueBoxRoot.SetActive(false);
        }

        if (!lookup.ContainsKey(speaker)) return;

        currentCharacter = lookup[speaker];
        currentCharacter.dialogueBoxRoot.SetActive(true);

        // Show buttons only if dialogue is active
        if (currentCharacter.nextButton != null)
        {
            currentCharacter.nextButton.gameObject.SetActive(true);
            currentCharacter.nextButton.onClick.RemoveAllListeners();
            currentCharacter.nextButton.onClick.AddListener(OnNextPressed);
        }

        if (currentCharacter.skipButton != null)
        {
            currentCharacter.skipButton.gameObject.SetActive(true);
            currentCharacter.skipButton.onClick.RemoveAllListeners();
            currentCharacter.skipButton.onClick.AddListener(StartSkip);
            UpdateSkipButtonState();
        }
    }
    //Hide UI buttons from view when not in use, make sure the panel is hidden
    void HideButtons()
    {
        foreach (var c in characters)
        {
            if (c.nextButton != null)
                c.nextButton.gameObject.SetActive(false);
            if (c.skipButton != null)
                c.skipButton.gameObject.SetActive(false);
        }
    }

    void RefreshButtons()
    {
        if (currentCharacter == null) return;

        if (currentCharacter.nextButton != null)
            currentCharacter.nextButton.gameObject.SetActive(true);

        if (currentCharacter.skipButton != null)
        {
            currentCharacter.skipButton.gameObject.SetActive(true);
            currentCharacter.skipButton.interactable = !skipLocked;
        }
    }

    //Checking to see if button needs to be greyed out or not
    void UpdateSkipButtonState()
    {
        if (currentCharacter?.skipButton != null)
        {
            currentCharacter.skipButton.interactable = !skipLocked;
        }
    }

    //Coroutine used to create the type writer effect for the line
    IEnumerator TypeLine(string line)
    {
        isTyping = true;
        currentCharacter.dialogueText.text = "";

        soundTimer = 0f;

        for (int i = 0; i < line.Length; i++)
        {
            currentCharacter.dialogueText.text += line[i];

            soundTimer -= currentCharacter.typingSpeed;

            if (!char.IsWhiteSpace(line[i]) && soundTimer <= 0f && currentCharacter.typingSounds != null && currentCharacter.typingSounds.Length > 0)
            {
                soundFXManager.PlayRandomSound
                (
                    currentCharacter.typingSounds,
                    currentCharacter.typingVolume
                );

                soundTimer = currentCharacter.soundDelay;
            }

            yield return new WaitForSeconds(currentCharacter.typingSpeed);
        }

        isTyping = false;

        //DisplayChoices(); Commented out for testing might have to remove later depending on conflicts }
    }

    //initiate the line
    void StartTyping(string line)
    {
        if (currentCharacter == null) return;

        // full reset of sound state
        soundTimer = 0f;
        soundFXManager.Stop();

        currentLine = line;

        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(TypeLine(line));
    }

    //destory line
    void FinishTyping()
    {
        StopAllCoroutines();
        currentCharacter.dialogueText.text = currentLine;
        isTyping = false;

        soundFXManager.Stop(); // stop overlapping sounds
        soundTimer = 0f; // 

    }

    //check and display any player choices
    void DisplayChoices()
    {
        // Hide all dialogue buttons during choices
        foreach (var c in characters)
        {
            if (c.nextButton != null) c.nextButton.gameObject.SetActive(false);
            if (c.skipButton != null) c.skipButton.gameObject.SetActive(false);
        }

        // Clear old buttons
        foreach (Transform child in choiceContainer)
            Destroy(child.gameObject);

        if (story.currentChoices.Count == 0)
        {
            choicePanel.SetActive(false);
            return;
        }

        // Hide all dialogue boxes before showing choices
        foreach (var c in characters)
            c.dialogueBoxRoot.SetActive(false);

        // Show panel only when there are choices
        choicePanel.SetActive(true);

        foreach (Choice choice in story.currentChoices)
        {
            Button button = Instantiate(choicePrefab, choiceContainer);
            button.GetComponentInChildren<TextMeshProUGUI>().text = choice.text;

            int choiceIndex = choice.index;

            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() =>
            {
                story.ChooseChoiceIndex(choiceIndex);

                choicePanel.SetActive(false); // Hide immediately after click

                ContinueStory();
            });
        }
    }

    // Deactivates all dialogue boxes
    void CloseAllDialogueBoxes()
    {
        foreach (var c in characters)
        {
            c.dialogueBoxRoot.SetActive(false);
            if (c.nextButton != null)
                c.nextButton.gameObject.SetActive(false);
            if (c.skipButton != null)
                c.skipButton.gameObject.SetActive(false);
        }
    }

    //Code for skipping forward
    public void StartSkip()
    {
        if (skipLocked) return;

        isSkipping = true;
        skippedLines.Clear();
        StartCoroutine(SkipAll());
    }

    IEnumerator SkipAll()
    {
        while (story.canContinue)
        {
            string text = story.Continue().Trim();

            if (!string.IsNullOrEmpty(text))
            {
                skippedLines.Add(text);
            }

            yield return null;
        }

        isSkipping = false;
        ShowSkipSummary();
    }

    //Actual skip panel controls
    void ShowSkipSummary()
    {
        skipSummaryPanel.SetActive(true);

        string summary = "";
        foreach (var line in skippedLines)
            summary += line + "\n";

        skipSummaryText.text = summary;
    }

    // Trigger dialogue externally (e.g., after door opens)
    public void TriggerDialogue(string knotName)
    {
        StartDialogue(knotName);
    }
}

