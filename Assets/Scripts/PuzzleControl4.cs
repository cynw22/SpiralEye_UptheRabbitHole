using UnityEngine;

public class PuzzleControl4 : MonoBehaviour
{
    // PUZZLE #1 - WORD SCRAMBLE SUITCASE
    [Header("Word Scramble Chest")]
    public bool chestIsOpen;
    [SerializeField] public Sprite[] passcodeLetters;

    // PUZZLE #2 - ALICE PICK KEYS
    [Header("Drink-Me Bottles")]
    public int numBottles;
    public int numSafeBottles;
    public bool[] bottleLocations;
    public int[] safeBottleLocationIndex;
    public bool allBottlesFound;

    // PUZZLE #3 - EXIT
    [Header("Key")]
    public int[] buttonOrder;
    public int numButtons;
    public bool keyFound;

    // PUZZLE #4 - NAVIGATION
    //Lobby
    [SerializeField]public GameObject background_0; // lobby
    //Constance
    [SerializeField]public GameObject background_1; // bedroom
    [SerializeField]public GameObject background_2; // office
    //Alice Secret Room
    [SerializeField]public GameObject background_3; // secret
    //Background1
    [SerializeField]public GameObject background_4; //nursery
    //Background2
    [SerializeField]public GameObject background_5; //library
    //CheckAlice
    [SerializeField] bool isAlice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PUZZLE #1 - WORD SCRAMBLE PUZZLE
        chestIsOpen = false;

        // PUZZLE #2 - DRINK ME BOTTLES
        allBottlesFound = false;
        numBottles = 12;
        numSafeBottles = 5;
        bottleLocations = new bool[numBottles];
        safeBottleLocationIndex = new int[numSafeBottles];
        setSafeBottleLocations();

        // PUZZLE #3 - KEY
        keyFound = false;
        numButtons = 5;
        buttonOrder = new int[numButtons];
        setButtonOrder();


        //SetBackgroundZeroActive();


    }

    // PUZZLE #2 - DRINK ME BOTTLES
    // determine which locations will hold safe bottles
    public void setSafeBottleLocations()
    {
        for (int i = 0; i < safeBottleLocationIndex.Length; i++)
        {
            bool skip = false;

            // generate random bottle location
            int bottleLocation = Random.Range(0, numBottles);

            // if there are previous entries in safeBottleLocationIndex, check bottle location against previous locations
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (bottleLocation == safeBottleLocationIndex[j])
                    {
                        // if generated bottle location matches any previous locations, regenerate
                        skip = true;
                        i--;
                        break;
                    }
                }
            }

            if (!skip) { safeBottleLocationIndex[i] = bottleLocation; }
            
            // Debug.Log("Bottle location: " + safeBottleLocationIndex[i]);
            // Debug.Log("i = " + i);
        }
    }

    // PUZZLE #3 - KEY
    // determine the order of buttons to be pressed to open key box
    public void setButtonOrder()
    {
        /*
        for (int i = 0; i < numButtons; i++) { buttonOrder[i] = Random.Range(0, 1); }

        // lazy way of making sure not all buttons are the same, make sure the last two buttons are different from each other
        switch(buttonOrder[^2])
        {
            case 0: buttonOrder[^1] = 1; break;
            case 1: buttonOrder[^1] = 0; break;
        }
        */

        buttonOrder[0] = 0;
        buttonOrder[1] = 1;
        buttonOrder[2] = 1;
        buttonOrder[3] = 0;
        buttonOrder[4] = 1;
    }

    ////PUZZLE 4: Navigation
    //public void SetBackgroundZeroActive()
    //{
    //    background_0.SetActive(true);
    //    background_1.SetActive(false);
    //    background_2.SetActive(false);
    //    background_3.SetActive(false);
    //    background_4.SetActive(false);
    //    background_5.SetActive(false);
    //}

    //public void SetBackgroundOneActive()
    //{
    //    background_0.SetActive(false);
    //    background_3.SetActive(false);

    //    if (!isAlice)
    //    {
    //        background_1.SetActive(true);
    //        background_2.SetActive(false);
    //    }
    //    else
    //    {
    //        background_4.SetActive(true);
    //        background_5.SetActive(false);
    //    }
    //}

    //public void SetBackgroundTwoActive()
    //{
    //    background_0.SetActive(false);
    //    background_3.SetActive(false);

    //    if (!isAlice)
    //    {
    //        background_1.SetActive(false);
    //        background_2.SetActive(true);
    //    }
    //    else
    //    {
    //        background_4.SetActive(false);
    //        background_5.SetActive(true);
    //    }
    //}
    //public void SetBackgroundThreeActive()
    //{
    //    if (isAlice)
    //    {
    //        background_0.SetActive(false);
    //        background_1.SetActive(false);
    //        background_2.SetActive(false);
    //        background_3.SetActive(true);
    //        background_4.SetActive(false);
    //        background_5.SetActive(false);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isAlice == false)
                isAlice = true;
            else if (isAlice == true)
                isAlice = false;
        }
    }


}