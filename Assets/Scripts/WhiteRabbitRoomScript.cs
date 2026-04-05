using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class WhiteRabbitRoomScript : MonoBehaviour
{
    [SerializeField] public SwitchManager switchMan;
    [SerializeField] public PuzzleControl4 puzzleMan;

    //Lobby
    [SerializeField] public GameObject background_0;
 
    //Constance
    [SerializeField] public GameObject background_1;
    [SerializeField] public GameObject background_2;
   
    //Alice Secret Room
    [SerializeField] public GameObject background_3;

    //Background1
    [SerializeField] public GameObject background_4;
    
    //Background2
    [SerializeField] public GameObject background_5;


    [SerializeField] bool isAlice;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isAlice = !switchMan.sisterPOV;
        SetBackgroundZeroActive();
    }

    public void SetBackgroundZeroActive()
    {
        switchMan.allowSwitching = true;
        CheckEnd();
        background_0.SetActive(true);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(false);
    }

    public void SetBackgroundOneActive()
    {
        background_0.SetActive(false);
        background_3.SetActive(false);
        switchMan.allowSwitching = false;

        if (!isAlice)
        {
            background_1.SetActive(true);
            background_2.SetActive(false);
        }
        else {
            background_4.SetActive(true);
            background_5.SetActive(false);
        }
    }

    public void SetBackgroundTwoActive()
    {
        background_0.SetActive(false);
        background_3.SetActive(false);
        switchMan.allowSwitching = false;

        if (!isAlice)
        {
            background_1.SetActive(false);
            background_2.SetActive(true);
        }
        else
        {
            background_4.SetActive(false);
            background_5.SetActive(true);
        }
    }
    public void SetBackgroundThreeActive()
    {
        if (isAlice) {
            switchMan.allowSwitching = false;
            background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(true);
        background_4.SetActive(false);
        background_5.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        isAlice = !switchMan.sisterPOV;
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (isAlice == false)
        //        isAlice = true;
        //    else if (isAlice == true)
        //        isAlice = false;
        //}
    }
    public void CheckEnd() { 
        if (puzzleMan.allObjectsFound == true){
            SceneManager.LoadScene("ThePoster");
        }
    }
}

