using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class LevelSelectionScript : MonoBehaviour
{
    [SerializeField] GameObject background_0;
    [SerializeField] GameObject background_1;
    [SerializeField] GameObject background_2;
    [SerializeField] GameObject background_3;
    [SerializeField] GameObject background_4;
    [SerializeField] GameObject background_5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetBackgroundZeroActive();
    }

    public void SetBackgroundZeroActive()
    {
        background_0.SetActive(true);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(false);
    }

    public void SetBackgroundOneActive() {
        background_0.SetActive(false);
        background_1.SetActive(true);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(false);
    }

    public void SetBackgroundTwoActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(true);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(false);
    }
    public void SetBackgroundThreeActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(true);
        background_4.SetActive(false);
        background_5.SetActive(false);
    }
    public void SetBackgroundFourActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(true);
        background_5.SetActive(false);
    }
    public void SetBackgroundFiveActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(true);
    }

}



