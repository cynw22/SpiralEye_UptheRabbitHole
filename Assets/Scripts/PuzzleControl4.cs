using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

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
    public Popup newspaperPopup;
    [Header("Newspaper - Remove Env")]
    [SerializeField] public GameObject windowNewPop;
    [SerializeField] public Renderer windowNewEnv;
    private int windowVal = 0;

    // PUZZLE #3 - TIMER
    [Header("Timer")]
    [SerializeField] public float time;
    public int levelNumber;

    // PUZZLE #5 - EXIT CONSTRAINT
    [Header("Exit Constraint")]
    public bool allObjectsFound;
    public int totalEscapeRooms;
    public int escapeRoomsComplete;

    public static bool puzzleWon = false; // true if the player solved the puzzle
    [Header("User Feedback")]
    //// User Feedback
    [SerializeField] public GameObject winPopup;
    [SerializeField] public GameObject losePopup;
    private bool isWinDone;
    private bool isLoseDone;

    [Header("BackButtons")]
    [SerializeField] public GameObject Back1;
    [SerializeField] public GameObject Back2;
    [SerializeField] public GameObject Back3;
    [SerializeField] public GameObject Back4;
    [SerializeField] public GameObject Back5;

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
        newspaperPopup = completePaper.GetComponent<Popup>();
        allNewsFound = false;
        numNewsFound = 0;
        numNews = 5;
        //windowNewEnv = windowNewEnv.GetComponent<SpriteRenderer>();
        //windowNewPop = GameObject.Find("NewsClip1");

        // PUZZLE #4 - TIMER
        time = 1800;
        levelNumber = 4;

        // PUZZLE #5 - EXIT CONSTRAINT
        allObjectsFound = false;
        totalEscapeRooms = 4;
        escapeRoomsComplete = 0;
        winPopup.SetActive(false);
        losePopup.SetActive(false);

        windowVal = 0;
        
        isWinDone = false;
        isLoseDone = false;

        CloseBack();
    }


    public void Update()
    {
        time -= Time.deltaTime;

        if ((time <= 1) && (escapeRoomsComplete != totalEscapeRooms) && (!isLoseDone))
        {
            Debug.Log("You lost");
            //Add Lose here, door unlock
            //Invoke(nameof(MovetoPoster), 2f);
            losePopup.SetActive(true);
            isLoseDone=true;
        }

        if ((escapeRoomsComplete == totalEscapeRooms) && !isWinDone) {
            allObjectsFound = true; // Aki check event manager - white rabbit code for where the load scene is for win condition - nvm its reverted
            puzzleWon = true;
            //SceneManager.LoadScene("ThePoster");
            Debug.Log("You collected all the elements - go back to lobby");
            winPopup.SetActive(true);
            isWinDone=true;
        }

        if (allNewsFound) { newspaperPopup.CheckBackground(); Back1.SetActive(true); }
        if (!windowNewPop.activeSelf && (windowVal == 0)) { windowVal = 1;}
        //if (windowNewPop.activeSelf && (windowVal == 1)) { windowVal = 2; }
        //if (!windowNewPop.activeSelf && (windowVal == 2)) { RemoveWindow(); windowVal = 3; }
        //Debug.Log("Window Val = " + windowVal);
        if (windowVal == 1) { RemoveWindow(); windowVal = 3; }
    }

    public void RemoveWindow(){
        Color tmp = windowNewEnv.GetComponent<SpriteRenderer>().color;
        tmp.a = 0f;
        windowNewEnv.GetComponent<SpriteRenderer>().color = tmp;
    }

    public void CompleteNewspaper()
    {
        Debug.Log("CompleteNewspaper()");
        allNewsFound = true;
        escapeRoomsComplete++;
        newspaperPopup.ShowPopup();
    }

    public void MovetoPoster() {
        SceneManager.LoadScene("ThePoster");
    }

    public void ClosePopup() {
        losePopup.SetActive(false);
        winPopup.SetActive(false);
    }

    public void CloseBack() { 
        Back1.SetActive(false);
        Back2.SetActive(false);
        Back3.SetActive(false);
        Back4.SetActive(false);
        Back5.SetActive(false);
    }
}