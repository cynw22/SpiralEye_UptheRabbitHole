using UnityEngine;

public class Bookshelf : MonoBehaviour
{
    [SerializeField] PuzzleControl1 puzzleControl;
    [SerializeField] DrinkMeBottles[] bottles;
    public int numFoundBottles = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < puzzleControl.numSafeBottles; i++)
        {
            bottles[puzzleControl.safeBottleLocationIndex[i]].isSafe = true;
            Debug.Log("bottle " + bottles[puzzleControl.safeBottleLocationIndex[i]] + " set to safe");
        }
    }

    private void Update()
    {
        if (numFoundBottles == puzzleControl.numSafeBottles)
        {
            puzzleControl.allBottlesFound = true;
            Debug.Log("all bottles found");
        }
    }
}
