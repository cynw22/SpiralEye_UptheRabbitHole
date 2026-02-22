using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;

#region Helper Classes
[System.Serializable]

//Changing mood sprites in the inspector
public class MoodSprite
{
    public string moodName;
    public Sprite sprite;
}

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

    [Header("Mood Sprites")]
    public List<MoodSprite> moods;

    [Header("Typing")]
    public float typingSpeed = 0.02f;
}
#endregion

//Actual dialogue manager code below, including all inspector set up items
public class DialogueManager : MonoBehaviour
{
    [Header("Ink")]
    public TextAsset inkJSON; //the main json file for support
    private Story story; //the actual inky story instance

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
    public Button skipButton;

    [Header("Sound")]
    public SoundFXManager soundFXManager;
    public AudioClip[] typingSounds;

    private bool isTyping;
    private bool skipLocked;
    private bool isSkipping;

    private string currentLine;
    private Coroutine typingCoroutine;
    private List<string> skippedLines = new List<string>();

    //Start inky file
    void Start()
    {
        choicePanel.SetActive(false);
        lookup = new Dictionary<string, CharacterDialogueUI>();

        foreach (var c in characters)
        {
            lookup.Add(c.characterName, c);
            c.dialogueBoxRoot.SetActive(false);
        }

        story = new Story(inkJSON.text);

        if (skipButton != null)
            skipButton.onClick.AddListener(StartSkip);

        ContinueStory();
    }

    void Update() { 
        if (Input.GetKeyDown(KeyCode.Return)) 
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
    }

    //Check tags to see if text is allowed to be skipped or not, controls how much of the story should flow and if there are any tags stopping the flow
    void ContinueStory() 
    {
        if (!story.canContinue)
        {
            Debug.Log("End of story reached.");
            CloseAllDialogueBoxes(); // deactivate all dialogue boxes
            choicePanel.SetActive(false); // also hide choices
            return;
        }

        string text = story.Continue().Trim(); 
        
        HandleTags(story.currentTags);

        //Stops blank tags from populating the boxes
        if (string.IsNullOrEmpty(text))
        {
            // No text to display, skip creating dialogue box
            if (story.currentChoices.Count > 0)
            {
                DisplayChoices();
            }
            return;
        }

        //Skip logic
        if (isSkipping) 
        { 
            skippedLines.Add(text); 
            
            if (story.currentChoices.Count > 0) 
            { 
                isSkipping = false; 
                ShowSkipSummary(); 
                DisplayChoices(); 
                return; 
            } 
            ContinueStory(); 
            return; 
        } 
        
        StartTyping(text); 
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
            else if (tag.StartsWith("mood:"))
            {
                string mood = tag.Split(':')[1].Trim();
                SetMood(mood);
            }
            else if (tag.StartsWith("ending:"))
            {
                SceneManager.LoadScene(tag.Split(':')[1].Trim());
            }
            else if (tag == "noskip_start")
            {
                skipLocked = true;
            }
            else if (tag == "noskip_end")
            {
                skipLocked = false;
            }
        }
    }

    //Check for the active character and display they're correct box, destory any remaining boxes in the scene
    void ActivateCharacter(string speaker)
    {
        foreach (var c in characters)
            c.dialogueBoxRoot.SetActive(false);

        if (lookup.ContainsKey(speaker))
        {
            currentCharacter = lookup[speaker];
            currentCharacter.dialogueBoxRoot.SetActive(true);
        }
    }

    //Create mood switching for the borders
    void SetMood(string moodName)
    {
        if (currentCharacter == null) return;

        foreach (var mood in currentCharacter.moods)
        {
            if (mood.moodName == moodName)
            {
                currentCharacter.characterPfp.sprite = mood.sprite;
                return;
            }
        }
    }

    //Coroutine used to create the type writer effect for the line
    IEnumerator TypeLine(string line)
    {
        isTyping = true; 
        currentCharacter.dialogueText.text = ""; 
        
        for (int i = 0; i < line.Length; i++) 
        { 
            currentCharacter.dialogueText.text += line[i]; 
            
            if (!char.IsWhiteSpace(line[i]) && !soundFXManager.IsPlaying()) 
            { 
                soundFXManager.PlayRandomSound(typingSounds, 0.4f); 
            } 
            yield return 
                new WaitForSeconds(currentCharacter.typingSpeed); 
        }

        isTyping = false; 

        //DisplayChoices(); Commented out for testing might have to remove later depending on conflicts }
    }

    //initiate the line
    void StartTyping(string line)
    {
    if (currentCharacter == null) return;

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
    }

    //check and display any player choices
    void DisplayChoices()
    {
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
        }
    }

    //Code for skipping forward
    public void StartSkip()
    {
        if (skipLocked) return;

        isSkipping = true;
        skippedLines.Clear();
        ContinueStory();
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
}