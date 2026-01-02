using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using System.Collections;

//Dialouge Manager Code:
// Create a system with branching choices: https://www.youtube.com/watch?v=zbYuLu_8spI and https://www.youtube.com/watch?v=vY0Sk93YUhA
// Create a system with typing letters: https://www.youtube.com/watch?v=jTPOCglHejE
// Create a dialouge system in unity: https://www.youtube.com/watch?v=l8yI_97vjZs
// Create a dialouge system with names, portraits and layouts: https://www.youtube.com/watch?v=tVrxeUIEV9E and https://stackoverflow.com/questions/77964808/unity-dialogue-system-for-multiple-dialogues-in-the-scene
// System Seralizable: https://discussions.unity.com/t/can-someone-explain-what-system-serializable-does-im-confused/791567
public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public PlayerInput playerInput;

    [Header("UI")]
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI promptText; // "Press Enter to Continue"
    public GameObject choiceButtonPrefab;  // Prefab for the choice buttons
    public Transform choicesContainer;     // Container to hold choice buttons

    [Header("Characters")]
    public Character Alice;
    public Character Constance;
    public Character[] npcCharacters; // NPCs (can be set in the inspector)

    [Header("Relationship Points")]
    public RelationshipPoints[] relationshipPoints; // Relationship points for Alice, Constance, and NPCs

    [Header("Dialogue Lines")]
    public DialogueLine[] AliceDialogue;   // Dialogue lines for Alice
    public DialogueLine[] ConstanceDialogue; // Dialogue lines for Constance
    public DialogueLine[] npcDialogue;    // Dialogue lines for NPCs (can be extended for multiple NPCs)

    [Header("Typing Settings")]
    public float typingSpeed = 0.02f;

    private string[] currentLines;
    private int lineIndex = 0;
    private bool isTyping = false;
    private bool isChoosing = false;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        if (playerInput == null) playerInput = FindObjectOfType<PlayerInput>();
    }

    // This starts the dialogue for a particular character
    public void StartDialogue(DialogueLine[] lines, Character speaker)
    {
        currentLines = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            currentLines[i] = lines[i].dialogueText; // Convert DialogueLine into a string array
        }

        lineIndex = 0;

        // Set the active dialogue box based on the speaker
        speaker.dialogueBox.SetActive(true);
        speaker.nameText.text = speaker.name;
        speaker.dialogueText.text = ""; // Reset dialogue text

        dialogueBox.SetActive(true);
        promptText.text = "Press Enter to Continue"; // Customizable prompt for user

        if (playerInput != null) playerInput.enabled = false; // Disable player movement during dialogue

        StartCoroutine(TypeLine());
    }

    // Show choices to the player (with mouse input support)
    public void ShowChoices(DialogueChoice[] choices)
    {
        isChoosing = true;

        // Clear existing choice buttons
        foreach (Transform child in choicesContainer)
        {
            Destroy(child.gameObject);
        }

        // Create a button for each choice
        foreach (var choice in choices)
        {
            GameObject button = Instantiate(choiceButtonPrefab, choicesContainer);
            TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = choice.choiceText;

            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(() => ApplyChoice(choice)); // When clicked, apply the choice
        }
    }

    // This is called when the player clicks a choice
    public void ApplyChoice(DialogueChoice choice)
    {
        isChoosing = false;

        // Adjust points for each affected character
        for (int i = 0; i < choice.affectedCharacters.Length; i++)
        {
            AdjustRelationshipPoints(choice.affectedCharacters[i], choice.pointChanges[i]);
        }

        // Proceed with the follow-up dialogue
        StartDialogue(choice.followUpLines, Alice); // For now, using Alice to continue
    }

    // Adjust relationship points for a specific character
    public void AdjustRelationshipPoints(string characterName, int pointChange)
    {
        foreach (var relationship in relationshipPoints)
        {
            if (relationship.characterName == characterName)
            {
                relationship.AdjustPoints(pointChange); // Apply the point change
                break;
            }
        }
    }

    // This updates the dialogue text line by line
    private void Update()
    {
        if (!dialogueBox.activeSelf || isChoosing) return;

        // Check for the Enter key
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = currentLines[lineIndex]; // Display the whole line immediately
                isTyping = false;
            }
            else
            {
                NextLine(); // Go to the next line of dialogue
            }
        }
    }

    // Move to the next line of dialogue
    private void NextLine()
    {
        lineIndex++;

        if (lineIndex < currentLines.Length)
        {
            StartCoroutine(TypeLine()); // If there are more lines, type them out
        }
        else
        {
            EndDialogue(); // End the dialogue when no more lines are left
        }
    }

    // Type the current line out letter by letter (typing effect)
    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogueText.text = "";

        string line = currentLines[lineIndex];

        foreach (char c in line)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed); // Typing speed control
        }

        isTyping = false;
    }

    // End the dialogue and re-enable player movement
    private void EndDialogue()
    {
        dialogueBox.SetActive(false);

        // Enable player movement once dialogue ends
        if (playerInput != null) playerInput.enabled = true;
    }

    // Start a new dialogue based on the character making the choice
    public void StartCharacterDialogue(Character speaker)
    {
        if (speaker == Alice)
        {
            StartDialogue(AliceDialogue, Alice); // Alice's dialogue
        }
        else if (speaker == Constance)
        {
            StartDialogue(ConstanceDialogue, Constance); // Constance's dialogue
        }
        else
        {
            // Handle NPCs dynamically (can choose the specific NPC in the inspector)
            StartDialogue(npcDialogue, npcCharacters[0]); // For example, set the first NPC to Cheshire Cat
        }
    }
}