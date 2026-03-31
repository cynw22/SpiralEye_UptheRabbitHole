using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;


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

    // ALL THE ROSES AND ROSE PARTICLES
    GameObject rose1;
    GameObject rose2;
    GameObject rose3;
    GameObject rose4;
    GameObject rose5;
    GameObject rose6;
    GameObject rose7;
    GameObject rose8;
    GameObject rose9;
    GameObject rose10;
    GameObject rose11;
    GameObject rose12;
    GameObject rose13;

    ParticleSystem rose1P;
    ParticleSystem rose2P;
    ParticleSystem rose3P;
    ParticleSystem rose4P;
    ParticleSystem rose5P;
    ParticleSystem rose6P;
    ParticleSystem rose7P;
    ParticleSystem rose8P;
    ParticleSystem rose9P;
    ParticleSystem rose10P;
    ParticleSystem rose11P;
    ParticleSystem rose12P;
    ParticleSystem rose13P;
    

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

        rose1 = GameObject.Find("Rose1");
        rose2 = GameObject.Find("Rose2");
        rose3 = GameObject.Find("Rose3");
        rose4 = GameObject.Find("Rose4");
        rose5 = GameObject.Find("Rose5");
        rose6 = GameObject.Find("Rose6");
        rose7 = GameObject.Find("Rose7");
        rose8 = GameObject.Find("Rose8");
        rose9 = GameObject.Find("Rose9");
        rose10 = GameObject.Find("Rose10");
        rose11 = GameObject.Find("Rose11");
        rose12 = GameObject.Find("Rose12");
        rose13 = GameObject.Find("Rose13");

        rose1P = GameObject.Find("Rose1Particle").GetComponent<ParticleSystem>();
        rose2P = GameObject.Find("Rose2Particle").GetComponent<ParticleSystem>();
        rose3P = GameObject.Find("Rose3Particle").GetComponent<ParticleSystem>();
        rose4P = GameObject.Find("Rose4Particle").GetComponent<ParticleSystem>();
        rose5P = GameObject.Find("Rose5Particle").GetComponent<ParticleSystem>();
        rose6P = GameObject.Find("Rose6Particle").GetComponent<ParticleSystem>();
        rose7P = GameObject.Find("Rose7Particle").GetComponent<ParticleSystem>();
        rose8P = GameObject.Find("Rose8Particle").GetComponent<ParticleSystem>();
        rose9P = GameObject.Find("Rose9Particle").GetComponent<ParticleSystem>();
        rose10P = GameObject.Find("Rose10Particle").GetComponent<ParticleSystem>();
        rose11P = GameObject.Find("Rose11Particle").GetComponent<ParticleSystem>();
        rose12P = GameObject.Find("Rose12Particle").GetComponent<ParticleSystem>();
        rose13P = GameObject.Find("Rose13Particle").GetComponent<ParticleSystem>();

        // PUZZLE #3 - TIMER
        time = 300;
        levelNumber = 5;
    }

    public void roseButton_OnClick()
    {
        numRosesFound += 1;
        GameObject roseFound = EventSystem.current.currentSelectedGameObject;
        roseFound.GetComponent<Button>().enabled = false;
        roseFound.GetComponent<Image>().enabled = false;
        roseFound.GetComponent<SwitchUI>().enabled = false;
        Debug.Log("Roses Picked Up: " + numRosesFound);
    }

    public void roseParticles()
    {
        //very inefficient but I just want it to work
        if (rose1.GetComponent<Button>().enabled == false)
        {
            rose1P.Play();
        }

        if (rose2.GetComponent<Button>().enabled == false)
        {
            rose2P.Play();
        }

        if (rose3.GetComponent<Button>().enabled == false)
        {
            rose3P.Play();
        }

        if (rose4.GetComponent<Button>().enabled == false)
        {
            rose4P.Play();
        }

        if (rose5.GetComponent<Button>().enabled == false)
        {
            rose5P.Play();
        }

        if (rose6.GetComponent<Button>().enabled == false)
        {
            rose6P.Play();
        }

        if (rose7.GetComponent<Button>().enabled == false)
        {
            rose7P.Play();
        }

        if (rose8.GetComponent<Button>().enabled == false)
        {
            rose8P.Play();
        }

        if (rose9.GetComponent<Button>().enabled == false)
        {
            rose9P.Play();
        }

        if (rose10.GetComponent<Button>().enabled == false)
        {
            rose10P.Play();
        }

        if (rose11.GetComponent<Button>().enabled == false)
        {
            rose11P.Play();
        }

        if (rose12.GetComponent<Button>().enabled == false)
        {
            rose12P.Play();
        }

        if (rose13.GetComponent<Button>().enabled == false)
        {
            rose13P.Play();
        }
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