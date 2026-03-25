using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class RoseGardenScript : MonoBehaviour
{

    [SerializeField] GameObject background_1;
    [SerializeField] GameObject background_2;
    [SerializeField] GameObject background_3;
    [SerializeField] GameObject background_4;
    [SerializeField] GameObject background_5;
    [SerializeField] GameObject background_6;
    [SerializeField] GameObject background_7;
    [SerializeField] GameObject background_8;
    [SerializeField] GameObject background_9;
    [SerializeField] GameObject background_10;
    [SerializeField] bool isAlice;


    public void Background2() {
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_1.SetActive(false);
        background_2.SetActive(true);
    }


    public void CheckActive()
    {
        //if (isAlice == true)
        //{
        //    c_hintMenu.SetActive(false);
        //    if (a_hintMenu.active)
        //        a_hintMenu.SetActive(false);
        //    else
        //        a_hintMenu.SetActive(true);
        //}

        //if (isAlice == false)
        //{
        //    a_hintMenu.SetActive(false);
        //    if (c_hintMenu.active)
        //        c_hintMenu.SetActive(false);
        //    else
        //        c_hintMenu.SetActive(true);
        //}

    }

    private void Start()
    {
        isAlice = false;
        background_1.SetActive(true);
        background_2.SetActive(false);
        background_3.SetActive(false);
        background_4.SetActive(false);
        background_5.SetActive(false);
        background_6.SetActive(false);
        background_7.SetActive(false);
        background_8.SetActive(false);
        background_9.SetActive(false);
        background_10.SetActive(false);

    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    c_hintMenu.SetActive(false);
        //    a_hintMenu.SetActive(false);

        //    if (isAlice == false)
        //        isAlice = true;
        //    else if (isAlice == true)
        //        isAlice = false;
        //}


        //if (Input.GetKeyDown(KeyCode.H))
        //{
        //    CheckActive();
        //}
    }

}
