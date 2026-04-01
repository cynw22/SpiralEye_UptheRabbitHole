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
    public int numRosesFound;
    public int numSafeRoses;
    public bool[] roseLocations;
    public int[] safeRoseLocationIndex;
    public bool allObjectsFound;

    public SwitchManager switchManager;

    //EXIT BUTTON
    public GameObject exitButton;
    public ParticleSystem exitParticleFinished;
    public ParticleSystem exitParticleUnfinished;

    // ALL THE ROSES AND ROSE PARTICLES
    public GameObject rose1;
    public GameObject rose2;
    public GameObject rose3;
    public GameObject rose4;
    public GameObject rose5;
    public GameObject rose6;
    public GameObject rose7;
    public GameObject rose8;
    public GameObject rose9;
    public GameObject rose10;
    public GameObject rose11;
    public GameObject rose12;
    public GameObject rose13;

    public ParticleSystem rose1P;
    public ParticleSystem rose2P;
    public ParticleSystem rose3P;
    public ParticleSystem rose4P;
    public ParticleSystem rose5P;
    public ParticleSystem rose6P;
    public ParticleSystem rose7P;
    public ParticleSystem rose8P;
    public ParticleSystem rose9P;
    public ParticleSystem rose10P;
    public ParticleSystem rose11P;
    public ParticleSystem rose12P;
    public ParticleSystem rose13P;
    

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

        exitParticleFinished = GameObject.Find("ExitParticleFinished").GetComponent<ParticleSystem>();
        exitParticleUnfinished = GameObject.Find("ExitParticleUnfinished").GetComponent<ParticleSystem>();

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
        roseParticles();
    }

    public void exitButton_OnClick()
    {
        if (numRosesFound >= 11)
        {
            SceneManager.LoadScene("GardenParty");
        }

        else if (numRosesFound < 11)
        {
            exitParticleUnfinished.Play();
        }
    }

    public void roseParticles()
    {
        //very inefficient but I just want it to work
        if (rose1.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
        {
            rose1P.Play();
        }

        if (rose2.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
        {
            rose2P.Play();
        }

        if (rose3.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
        {
            rose3P.Play();
        }

        if (rose4.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
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

    void LateUpdate()
    {
        var switchControl = UserInput.instance.controls.Player.Switch;
        if (switchControl.WasPressedThisFrame())
        {
            if (rose1.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose1P.Play();
            }

            else if (rose1.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose1P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose2.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose2P.Play();
            }

            else if (rose2.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose2P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose3.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose3P.Play();
            }

            else if (rose3.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose3P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose4.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose4P.Play();
            }

            else if (rose4.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose4P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose5.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose5P.Play();
            }

            else if (rose5.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose5P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose6.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose6P.Play();
            }

            else if (rose6.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose6P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose7.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose7P.Play();
            }

            else if (rose7.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose7P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose8.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose8P.Play();
            }

            else if (rose8.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose8P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose9.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose9P.Play();
            }

            else if (rose9.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose9P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose10.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose10P.Play();
            }

            else if (rose10.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose10P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose11.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose11P.Play();
            }

            else if (rose11.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose11P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose12.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose12P.Play();
            }

            else if (rose12.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose12P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            if (rose13.GetComponent<Button>().enabled == false && switchManager.sisterPOV == false)
            {
                rose13P.Play();
            }

            else if (rose13.GetComponent<Button>().enabled == false && switchManager.sisterPOV == true)
            {
                rose13P.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
        }

        if (numRosesFound >= 11)
        {
            exitParticleFinished.Play();
            exitParticleUnfinished.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }
}