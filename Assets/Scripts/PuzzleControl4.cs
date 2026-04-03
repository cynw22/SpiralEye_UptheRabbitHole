using UnityEngine;
using UnityEngine.SceneManagement;

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

    // PUZZLE ?? - Curiosity killed the cat
    [Header("Curiosity killed the cat")]
    public bool catBookFound;

    // PUZZLE #3 - NEWSPAPER PUZZLE
    [Header("Newspaper")]
    public int numNews;
    public int numNewsFound;
    public bool allNewsFound;
    [SerializeField] public GameObject completePaper;

    // PUZZLE #3 - TIMER
    [Header("Timer")]
    [SerializeField] public float time;
    public int levelNumber;

    // PUZZLE #5 - EXIT CONSTRAINT
    public bool allObjectsFound;
    public int totalEscapeRooms;
    public int escapeRoomsComplete;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PUZZLE #1 - WORD SCRAMBLE PUZZLE
        suitcaseIsOpen = false;

        //  PUZZLE #2 - Keys puzzle
        allKeysFound = false;
        numKeys = 3;

        // PUZZLE ?? - catbook
        catBookFound = false;

        //PUZZLE #3 - Newspaper puzzle
        completePaper.SetActive(false);
        allNewsFound = false;
        numNewsFound = 0;
        numNews = 5;

        // PUZZLE #4 - TIMER
        time = 1800;
        levelNumber = 4;

        // PUZZLE #5 - EXIT CONSTRAINT
        allObjectsFound = false;
        totalEscapeRooms = 4;
        escapeRoomsComplete = 0;
    }

    public void Update()
    {
        time -= Time.deltaTime;

        if ((time <= 1) && (escapeRoomsComplete!=totalEscapeRooms))
        {
            SceneManager.LoadScene("WhiteRabbitPuzzle"); //Change Later to ThePoster
        }
    }
}