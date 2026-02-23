using UnityEngine;
using System.Collections.Generic;
using System;

public class KeyBox : MonoBehaviour
{
    [SerializeField] PuzzleControl1 puzzleControl;

    public int[] sequence;
    public int inputs = 0;
    [SerializeField] public GameObject[] checks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sequence = new int[puzzleControl.numButtons];

        for (int i = 0; i < checks.Length; i++)
        {
            checks[i].SetActive(false);
        }
    }

    public void buttonPress(int isDrinkMe)
    {
        sequence[inputs] = isDrinkMe;

        // check if new button input matches the correct order of button presses
        if (sequence[inputs] == puzzleControl.buttonOrder[inputs])
        {
            Debug.Log(sequence[inputs]);
            checks[inputs].SetActive(true);
            inputs++;
            puzzleControl.keyFound = inputs == puzzleControl.numButtons ? true : false;
        }
        // if wrong, reset all checkmarks and reset the input sequence
        else
        {
            for (int i = 0; i < checks.Length; i++)
            {
                checks[i].SetActive(false);
            }
            Array.Clear(sequence, 0, sequence.Length);
            inputs = 0;
        }
    }
}
