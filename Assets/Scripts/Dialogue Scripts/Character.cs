using UnityEngine;
using TMPro;

[System.Serializable]
public class Character
{
    public string name; //Character Name idk I added this so we can call it in functions for internal purposes but if it's useless we can delete it
    public GameObject dialogueBox; // Add the character specific dialouge boxes here
    public TextMeshProUGUI nameText; //Character TAG Name to show up in our dialouge box
    public TextMeshProUGUI dialogueText; //Dialouge Text
}
