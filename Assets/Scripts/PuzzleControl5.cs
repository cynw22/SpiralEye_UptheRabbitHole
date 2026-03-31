using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class PuzzleControl5 : MonoBehaviour
{
    // PUZZLE #2 - ALICE ROSES
    [Header("A_Roses")]
    public int numRoses;
    int numRosesFound;
    public int numSafeRoses;
    public bool[] roseLocations;
    public int[] safeRoseLocationIndex;
    public bool allObjectsFound;

    // PUZZLE #3 - TIMER
    [Header("Timer")]
    [SerializeField] public float time;
    public int levelNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PUZZLE #2 - DRINK ME BOTTLES
        allObjectsFound = false;
        numRoses = 13;
        numRosesFound = 0;
        numSafeRoses = 5;
        roseLocations = new bool[numRoses];
        safeRoseLocationIndex = new int[numSafeRoses];
        setSafeRoseLocations();

        // PUZZLE #3 - TIMER
        time = 300;
        levelNumber = 5;
    }

    public void roseButton_OnClick()
    {
        numRosesFound += 1;
        GameObject roseFound = EventSystem.current.currentSelectedGameObject;
        roseFound.SetActive(false);
    }

    // PUZZLE #2 - DRINK ME BOTTLES
    // determine which locations will hold safe bottles
    public void setSafeRoseLocations()
    {
        for (int i = 0; i < safeRoseLocationIndex.Length; i++)
        {
            bool skip = false;

            // generate random bottle location
            int bottleLocation = Random.Range(0, numRoses);

            // if there are previous entries in safeBottleLocationIndex, check bottle location against previous locations
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (bottleLocation == safeRoseLocationIndex[j])
                    {
                        // if generated bottle location matches any previous locations, regenerate
                        skip = true;
                        i--;
                        break;
                    }
                }
            }

            if (!skip) { safeRoseLocationIndex[i] = bottleLocation; }
            
            // Debug.Log("Bottle location: " + safeBottleLocationIndex[i]);
            // Debug.Log("i = " + i);
        }
    }

    // PUZZLE #3 - KEY
    // determine the order of buttons to be pressed to open key box
    public void Update()
    {
        time -= Time.deltaTime;

        if ((time <= 1) && (!allObjectsFound))
        {    
                SceneManager.LoadScene("FindTheRose"); //Change Later to Queens Court
        }

        if (numRosesFound == numRoses)
        {
            allObjectsFound = true;
        }
    }
}