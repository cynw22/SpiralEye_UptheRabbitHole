using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class ExplanationPopupQueen : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject toDisplay;
    [SerializeField] public TextAsset inkJSONFile;
    private Story madHatterWinStory;

    //static bool QueenInvite = false; // checks if QueenInvite is ture or false - true = open popup, false = close popup

    private int popupState = 0;
    private float startupDelay = 0.5f; // Wait half a second
    private float timer = 0f;

    void Start()
    {
        madHatterWinStory = new Story(inkJSONFile.text);

        //QueenData data = JsonUtility.FromJson<QueenData>(inkJSONFile.text);
        //QueenInvite = data.QueenInvite;

        // Start hidden to prevent the "flicker"
        toDisplay.SetActive(false);
        popupState = 0;
    }

    void Update()
    {

        // 1. Accessing a Boolean
        bool queenInvite = (bool)madHatterWinStory.variablesState["QueenInvite"];

        if (popupState != 0) return;

        // 1. Wait for the startup delay to pass
        //if (timer < startupDelay)
        //{
        //    timer += Time.deltaTime;
        //    return;
        //}

        if (queenInvite) {
            OpenPanel();
        }
        if (!queenInvite)
        {
            ClosePanel();
        }
    }

    public void OpenPanel()
    {
        toDisplay.SetActive(true);
        popupState = 1;
    }

    public void ClosePanel()
    {
        toDisplay.SetActive(false);
        popupState = 2;
        Debug.Log("Popup closed and state set to 2.");
    }
}