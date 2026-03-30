using UnityEngine;
using System.Collections.Generic;
using System;

public class KeyBox : MonoBehaviour
{
    [SerializeField] PuzzleControl1 puzzleControl;
    [SerializeField] SwitchManager switchManager;

    private SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite sprite1, sprite2;
    [SerializeField] public GameObject complete;

    public int[] sequence;
    public int inputs = 0;
    [SerializeField] public GameObject[] checks;
    [SerializeField] public GameObject eatMe;
    [SerializeField] public GameObject drinkMe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sequence = new int[puzzleControl.numButtons];
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;

        for (int i = 0; i < checks.Length; i++)
        {
            checks[i].SetActive(false);
        }

        eatMe.SetActive(false);
        drinkMe.SetActive(false);
        complete.SetActive(false);
    }

    private void Update()
    {
        if (puzzleControl.chestIsOpen) { eatMe.SetActive(true); }
        if (puzzleControl.allBottlesFound) { drinkMe.SetActive(true); }
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
            if (puzzleControl.keyFound) { spriteRenderer.sprite = sprite2; complete.SetActive(true); }
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
