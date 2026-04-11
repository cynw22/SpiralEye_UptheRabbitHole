using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class WhiteRabbitRoomScript : MonoBehaviour
{
    [SerializeField] public SwitchManager switchMan;
    [SerializeField] public PuzzleControl4 puzzleMan;
    [SerializeField] public GameObject Dialouge;
    [SerializeField] public GameObject SpaceBar;
    [SerializeField] public GameObject SpaceBar2;
    //[SerializeField] public Sprite noSpace;
    [SerializeField] public Sprite yesSpace;
    [SerializeField] private Sprite noSpace;
    [SerializeField] private Image srSpaceBar;
    [SerializeField] private Image srSpaceBar2;


    [SerializeField] public GameObject BackButton;
    
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
        Time.timeScale = 1.0f;
        isAlice = !switchMan.sisterPOV;
        SetBackgroundZeroActive();
        Dialouge.SetActive(false);
        srSpaceBar = SpaceBar.GetComponent<Image>();
        if (srSpaceBar == null)
        {
            Debug.LogError("No Image found on SpaceBarUI");
            enabled = false;
            return;
        }
        noSpace = srSpaceBar.sprite;
        
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
        Dialouge.SetActive(false);
        Time.timeScale = 1.0f;
        RevertSprite();
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
            ChangeSpriteAlice();
        }
        else {
            background_4.SetActive(true);
            background_5.SetActive(false);
            ChangeSpriteConstance();
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
            ChangeSpriteAlice();
        }
        else
        {
            background_4.SetActive(false);
            background_5.SetActive(true);
            ChangeSpriteConstance();
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
            Dialouge.SetActive(true);
            Time.timeScale = 0f;
        }
        ChangeSpriteConstance();
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
        if (puzzleMan.time <= 0) {
            SceneManager.LoadScene("ThePoster");
        }

    }

    public void ChangeSpriteAlice()
    {
        if (yesSpace != null)
        {
            srSpaceBar.sprite = yesSpace;
            Color tempColor = srSpaceBar.color;
            tempColor.a = 1.0f; // Set alpha to 100%
            srSpaceBar.color = tempColor;
        }
        else
        {
            Debug.LogWarning("yesSpace is not assigned.");
        }
        BackButton.gameObject.SetActive(true);

    }

    public void ChangeSpriteConstance()
    {
        if (yesSpace != null)
        {
            srSpaceBar2.sprite = yesSpace;
            Color tempColor = srSpaceBar2.color;
            tempColor.a = 1.0f; // Set alpha to 100%
            srSpaceBar2.color = tempColor;
        }
        else
        {
            Debug.LogWarning("yesSpace is not assigned.");
        }
        BackButton.gameObject.SetActive(true);

    }

    // Call this method to revert to the original sprite
    public void RevertSprite()
    {
        srSpaceBar.sprite = noSpace;
        Color tempColor = srSpaceBar.color;
        tempColor.a = 0.0f; // Set alpha to 0%
        srSpaceBar.color = tempColor;
        srSpaceBar2.color = tempColor;
        BackButton.gameObject.SetActive(false);
    }

}

