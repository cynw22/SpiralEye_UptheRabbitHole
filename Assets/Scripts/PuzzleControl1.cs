using UnityEngine;

public class PuzzleControl1 : MonoBehaviour
{
    // PUZZLE #1 - WORD SCRAMBLE CHEST
    [Header("Word Scramble Chest")]
    public bool chestIsOpen;
    public string chestPasscode;

    // PUZZLE #2 - DRINK ME BOTTLES
    [Header("Drink-Me Bottles")]
    public int numBottles;
    public int numSafeBottles;
    public bool[] bottleLocations;
    public int[] safeBottleLocationIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PUZZLE #1 - WORD SCRAMBLE PUZZLE
        chestIsOpen = false;
        chestPasscode = "SPIRE";

        // PUZZLE #2 - DRINK ME BOTTLES
        numBottles = 9;
        numSafeBottles = 4;
        bottleLocations = new bool[numBottles];
        safeBottleLocationIndex = new int[numSafeBottles];
        setSafeBottleLocations();
    }

    // PUZZLE #1 - WORD SCRAMBLE CHEST
    // take player's attempted passcode, compare to chest passcode. if same, open chest
    public bool tryPasscode(string passcode)
    {
        if (chestPasscode.Equals(passcode))
        {
            chestIsOpen = true;
        }

        return chestIsOpen;
    }

    // PUZZLE #2 - DRINK ME BOTTLES
    // determine which locations will hold safe bottles
    public void setSafeBottleLocations()
    {
        for (int i = 0; i < safeBottleLocationIndex.Length; i++)
        {

        }
    }
}