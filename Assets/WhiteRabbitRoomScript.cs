using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class WhiteRabbitRoomScript : MonoBehaviour
{
    [SerializeField] GameObject background_0;
    [SerializeField] GameObject background_1;
    [SerializeField] GameObject background_2;
    [SerializeField] GameObject background_3;
    [SerializeField] bool isAlice;


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
    }

    public void SetBackgroundOneActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(true);
        background_2.SetActive(false);
        background_3.SetActive(false);

    }

    public void SetBackgroundTwoActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(true);
        background_3.SetActive(false);

    }
    public void SetBackgroundThreeActive()
    {
        background_0.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(false);
        background_3.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isAlice == false)
                isAlice = true;
            else if (isAlice == true)
                isAlice = false;
        }
    }

}

