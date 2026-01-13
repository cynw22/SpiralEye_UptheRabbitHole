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
}