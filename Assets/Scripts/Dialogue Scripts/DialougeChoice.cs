[System.Serializable]
public class DialogueChoice
{
    public string choiceText; //Actual Choice Text
    public DialogueLine[] followUpLines; // Dialogue lines that follow this choice
    public int pointChange; // How the choice affects the point system (+ or -)

    // Arrays to track which characters' points are affected and how
    public string[] affectedCharacters; // Array of character names affected by the choice
    public int[] pointChanges; // Array of corresponding point changes for each character

    // Constructor to initialize a dialogue choice
    public DialogueChoice(string choice, DialogueLine[] followUp, int pointChange, string[] affectedCharacters, int[] pointChanges)
    {
        this.choiceText = choice;
        this.followUpLines = followUp;
        this.pointChange = pointChange;
        this.affectedCharacters = affectedCharacters;
        this.pointChanges = pointChanges;
    }
}

