using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;

#region Character UI Definition
[System.Serializable]

//Used to create dynamic dialogue boxes, will also control the portrait moods for the girls and the speed in which dialogue appears
public class CharacterDialogueUI
{
    public string characterName;

    [Header("UI References")]
    public GameObject dialogueBoxRoot; //The box base
    public TextMeshProUGUI dialogueText; //Text type
    public Image portraitImage; // UI character portrait

    [Header("Portrait Settings")]
    public Sprite neutralSprite; //Will be used to reset the character sprite back to normal after a change

    [Header("Typing Settings")]
    public float typingSpeed = 0.03f; //typing speed
}
#endregion

public class DialogueManager : MonoBehaviour
{
    [Header("Ink")]
    public TextAsset inkJSON; //Connecting the JSON file
    private Story story; //Actually used to call the ink story instance

    [Header("Character Dialogue")]
    public List<CharacterDialogueUI> characters; // The set up for all characters

    private Dictionary<string, CharacterDialogueUI> characterLookup;
    private CharacterDialogueUI currentCharacter; //Current speaker

    [Header("Choices")]
    public Transform choiceContainer; //The choice parent
    public Button choicePrefab; //The choice button

    [Header("Skip UI")]
    public GameObject skipSummaryPanel; //Summary panel
    public TextMeshProUGUI skipSummaryText; //Summary Text
    public Button skipButton; //Summary Button

    [Header("Typing Audio")]
    public SoundFXManager soundFXManager;
    public AudioClip[] typingSounds;
    public float typingSoundFrequency = 0.05f;

    private bool isTyping = false;
    private bool isSkipping = false;
    private bool skipLocked = false;

    private string currentLine;
    private Coroutine typingCoroutine;
    private List<string> skippedLines = new List<string>();

    #region Initialization
    void Start()
    {
        //Will be used to find characters faster (dictionary is used for this)
        SetupCharacterDictionary();
        StartStory();

        //Hooking up the skip button to function correctly
        if (skipButton != null)
            skipButton.onClick.AddListener(StartSkip);
    }

    //This dictionary will be used to map a character name to their specific set up. will allow for faster lookup time and disable all boxes at the start of each scene
    void SetupCharacterDictionary()
    {
        characterLookup = new Dictionary<string, CharacterDialogueUI>();

        foreach (var character in characters)
        {
            characterLookup.Add(character.characterName, character);
            character.dialogueBoxRoot.SetActive(false);
        }
    }

    void StartStory()
    {
        story = new Story(inkJSON.text);
        ContinueStory();
    }
    #endregion

    #region Update
    void Update()
    {
        //Uses enter key, checks to see if typing is finished and story is finished, will also break if a choice is presented
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (story.currentChoices.Count > 0)
                return;

            if (isTyping)
                FinishTyping();
            else
                ContinueStory();
        }
    }
    #endregion

    #region Story Flow

    //Will be used to move from one scene to the next in listed order, will check for when the story ends as well
    void ContinueStory()
    {
        if (!story.canContinue)
        {
            Debug.Log("End of story reached.");
            return;
        }

        string text = story.Continue().Trim();

        //Used to process any tags attached to the current line
        HandleTags(story.currentTags);

        //If skipping occurs, showcase the summary and fast forward the text
        if (isSkipping)
        {
            skippedLines.Add(text);

            if (story.currentChoices.Count > 0)
            {
                StopSkipping();
                ShowSkipSummary();
                DisplayChoices();
                return;
            }

            ContinueStory();
            return;
        }

        StartTyping(text);
        DisplayChoices();
    }
    #endregion

    #region Tag Handling

    //All tags listed in ink file, will be called when needed by other functions or used to dictate something in the scene like visuals
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
                string[] parts = tag.Split(':');
                string speaker = parts[1].Trim();
                string mood = parts[2].Trim();
                UpdateCharacterMood(speaker, mood);
            }
            else if (tag.StartsWith("ending:"))
            {
                string sceneName = tag.Split(':')[1].Trim();
                SceneManager.LoadScene(sceneName);
            }
            else if (tag == "noskip_start")
            {
                skipLocked = true;
            }
            else if (tag == "noskip_end")
            {
                skipLocked = false;
            }
            else if (tag.StartsWith("summary:"))
            {
                string summary = tag.Substring("summary:".Length).Trim();
                skippedLines.Add(summary);
            }
        }
    }
    #endregion

    #region Character Handling
    //Checks who is the active character and disables all other boxes while they speak
    void ActivateCharacter(string speaker)
    {
        foreach (var character in characters)
            character.dialogueBoxRoot.SetActive(false);

        if (characterLookup.ContainsKey(speaker))
        {
            currentCharacter = characterLookup[speaker];
            currentCharacter.dialogueBoxRoot.SetActive(true);
        }
        else
        {
            Debug.LogWarning("No UI assigned for speaker: " + speaker);
        }
    }

    //Change the portrait based on the mood
    void UpdateCharacterMood(string speaker, string mood)
    {
        if (!characterLookup.ContainsKey(speaker)) return;

        var character = characterLookup[speaker];

        Sprite newSprite = Resources.Load<Sprite>($"Sprites/{speaker}_{mood}");
        if (newSprite != null)
            character.portraitImage.sprite = newSprite;
    }


    //Reset the portrait back to normal
    void ResetPortraitToNeutral()
    {
        if (currentCharacter != null && currentCharacter.neutralSprite != null)
            currentCharacter.portraitImage.sprite = currentCharacter.neutralSprite;
    }
    #endregion

    #region Typewriter

    //Adding the typewriter effect to the lines of code, so everything flows out naturally
    void StartTyping(string line)
    {
        if (currentCharacter == null) return;

        currentLine = line;

        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(TypeLine(line));
    }

    //Type line using coroutine to reveal characters over time
    IEnumerator TypeLine(string line)
    {
        isTyping = true;
        currentCharacter.dialogueText.text = "";

        float soundTimer = 0f;

        foreach (char letter in line)
        {
            currentCharacter.dialogueText.text += letter;

            if (!char.IsWhiteSpace(letter))
            {
                soundTimer += currentCharacter.typingSpeed;

                //Sound effect for typing
                if (soundTimer >= typingSoundFrequency)
                {
                    if (typingSounds.Length > 0)
                        soundFXManager.PlayRandomSound(typingSounds, 0.5f);

                    soundTimer = 0f;
                }
            }

            yield return new WaitForSeconds(currentCharacter.typingSpeed);
        }

        isTyping = false;
        ResetPortraitToNeutral();
    }

    //Stop typing the line and end couroutine
    void FinishTyping()
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        currentCharacter.dialogueText.text = currentLine;
        isTyping = false;
        ResetPortraitToNeutral();
    }
    #endregion

    #region Choices

    //Visual display of choices and interaction with buttons
    void DisplayChoices()
    {
        foreach (Transform child in choiceContainer)
            Destroy(child.gameObject);

        if (story.currentChoices.Count > 0)
        {
            foreach (Choice choice in story.currentChoices)
            {
                Button button = Instantiate(choicePrefab, choiceContainer);
                button.GetComponentInChildren<TextMeshProUGUI>().text = choice.text;

                int choiceIndex = choice.index;

                button.onClick.AddListener(() =>
                {
                    story.ChooseChoiceIndex(choiceIndex);
                    ContinueStory();
                });
            }
        }
    }
    #endregion

    #region Skip System
    
    //Start the area to skip text
    public void StartSkip()
    {
        if (skipLocked)
        {
            Debug.Log("Skip disabled for this section.");
            return;
        }

        if (!isSkipping)
        {
            isSkipping = true;
            skippedLines.Clear();
            ContinueStory();
        }
    }

    void StopSkipping()
    {
        isSkipping = false;
    }

    //Show special panel for skipped text to showcase our condensed script
    void ShowSkipSummary()
    {
        skipSummaryPanel.SetActive(true);

        string summaryText = "";
        foreach (string line in skippedLines)
            summaryText += line + "\n";

        skipSummaryText.text = summaryText;
    }

    //Close skip panel
    public void CloseSkipSummary()
    {
        skipSummaryPanel.SetActive(false);
        ContinueStory();
    }
    #endregion
}