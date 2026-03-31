using UnityEngine;

public class PuzzleControl4 : MonoBehaviour
{
    // PUZZLE #1 - SUITCASE PUZZLE
    [Header("Word Scramble Suitcase")]
    public bool suitcaseIsOpen;
    [SerializeField] public Sprite[] passcodeLetters;

    // PUZZLE #2 - KEYS ALICE PUZZLE
    [Header("Key")]
    public int numKeys;
    public bool allKeysFound;

    // PUZZLE #3 - NEWSPAPER PUZZLE
    [Header("Newspaper")]
    public int numNews;
    public bool allNewsFound;

    // PUZZLE #3 - TIMER
    [Header("Timer")]
    [SerializeField] public float time;
    public int levelNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PUZZLE #1 - WORD SCRAMBLE PUZZLE
        suitcaseIsOpen = false;

        //  PUZZLE #2 - Keys puzzle
        allKeysFound = false;
        numKeys = 3;

        //PUZZLE #3 - Newspaper puzzle
        allNewsFound = false;
        numNews = 3; //change later

        // PUZZLE #3 - TIMER
        time = 1800;
        levelNumber = 4;
    }


}