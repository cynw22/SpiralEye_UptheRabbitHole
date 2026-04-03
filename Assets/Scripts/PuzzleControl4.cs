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
    //[SerializeField] public GameObject windowstillNewspaperEnvironment;
    //[SerializeField] public GameObject windowstillNewspaperPopup;


    // PUZZLE #3 - TIMER
    [Header("Timer")]
    [SerializeField] public float time;
    public int levelNumber;

    // PUZZLE #5 - EXIT CONSTRAINT
    public bool allObjectsFound;
    public int totalEscapeRooms;
    public int escapeRoomsComplete;

    //// User Feedback
    //[SerializeField] public GameObject breifCasePopup;
    //[SerializeField] public GameObject bookPopup;
    //[SerializeField] public GameObject newspaperPopup;
    //[SerializeField] public GameObject k1Popup;
    //[SerializeField] public GameObject k2Popup;
    //[SerializeField] public GameObject k3Popup;
    //[SerializeField] public GameObject k4Popup;
    //[SerializeField] public GameObject k5Popup;
    //[SerializeField] public GameObject k6Popup;
    //[SerializeField] public GameObject k7Popup;
    //[SerializeField] public GameObject k8Popup;

    //private bool briefCasePopupDone = false;
    //private bool bookPopupDone = false;
    //private bool newspaperPopupDone = false;
    //private bool k1PopupDone = false;
    //private bool k2PopupDone = false;
    //private bool k3PopupDone = false;
    //private bool k4PopupDone = false;
    //private bool k5PopupDone = false;
    //private bool k6PopupDone = false;
    //private bool k7PopupDone = false;
    //private bool k8PopupDone = false;

    ////Books Popup
    //GameObject booksNotTaken;
    //GameObject booksTaken;

    ////Books Environment
    //GameObject environmentTall;
    //GameObject environmentShort;
    //figma puzzle 3 / puzzle 2


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
        //windowstillNewspaperEnvironment = GameObject.Find("WindowStill");
        //windowstillNewspaperPopup = GameObject.Find("NewsClip1");

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
            SceneManager.LoadScene("FindTheRose"); //Change Later to ThePoster
        }

        if (escapeRoomsComplete == totalEscapeRooms) {
            SceneManager.LoadScene("FindTheRose"); // change later
        }

    }
}