using UnityEngine;

public class PuzzleControl1 : MonoBehaviour
{
    // PUZZLE #1 - WORD SCRAMBLE CHEST
    [Header("Word Scramble Chest")]
    public bool chestIsOpen;
    [SerializeField] public Sprite[] passcodeLetters;

    // PUZZLE #2 - DRINK ME BOTTLES
    [Header("Drink-Me Bottles")]
    public int numBottles;
    public int numSafeBottles;
    public bool[] bottleLocations;
    public int[] safeBottleLocationIndex;
    public bool allBottlesFound;

    // PUZZLE #3 - KEY
    [Header("Key")]
    public int[] buttonOrder;
    public int numButtons;
    public bool keyFound;

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
    }

    // PUZZLE #2 - DRINK ME BOTTLES
    // determine which locations will hold safe bottles
    public void setSafeBottleLocations()
    {
        for (int i = 0; i < safeBottleLocationIndex.Length; i++)
        {
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
                        i--;
                        break;
                    }
                }
            }
            safeBottleLocationIndex[i] = bottleLocation;
            Debug.Log("Bottle location: " + safeBottleLocationIndex[i]);
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
}