using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    public string speakerName;   // The name of the character speaking
    public string dialogueText;  // The dialogue text they are saying

    // Constructor to initialize the DialogueLine (optional)
    public DialogueLine(string speakerName, string dialogueText)
    {
        this.speakerName = speakerName;
        this.dialogueText = dialogueText;
    }
}