using UnityEngine;
using System.Collections.Generic;

public class KeyBox : MonoBehaviour
{
    [SerializeField] PuzzleControl1 puzzleControl;

    public List<bool> sequence;
    [SerializeField] public GameObject[] checks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sequence = new List<bool>();

        for (int i = 0; i < checks.Length; i++)
        {
            checks[i].SetActive(false);
        }
    }

    public void buttonPress(bool isDrinkMe)
    {
        sequence.Add(isDrinkMe);

        // check if new button input matches the correct order of button presses
        if (sequence.Count == puzzleControl.buttonOrder[sequence.Count])
        {
            checks[sequence.Count].SetActive(true);
            puzzleControl.keyFound = sequence.Count == puzzleControl.numButtons ? true : false;
        }
        // if wrong, reset all checkmarks and reset the input sequence
        else
        {
            for (int i = 0; i < checks.Length; i++)
            {
                checks[i].SetActive(false);
            }
            sequence.Clear();
        }
    }
}
