using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class Hint_Script : MonoBehaviour
{

    [SerializeField] GameObject a_hintMenu;
    [SerializeField] GameObject c_hintMenu;
    [SerializeField] bool isAlice;

    //public void OpenAliceHint() {
    //    a_hintMenu.SetActive(true);
    //}

    //public void CloseAliceHint()
    //{
    //    a_hintMenu.SetActive(false);
    //}

    //public void OpenConstanceHint()
    //{
    //    c_hintMenu.SetActive(true);
    //}

    //public void CloseConstanceHint()
    //{
    //    c_hintMenu.SetActive(false);
    //}

    public void CheckActive() {
        if (isAlice == true)
        {
            c_hintMenu.SetActive(false);
            if (a_hintMenu.active)
                a_hintMenu.SetActive(false);
            else
                a_hintMenu.SetActive(true);
        }

        if (isAlice == false)
        {
            a_hintMenu.SetActive(false);
            if (c_hintMenu.active)
                c_hintMenu.SetActive(false);
            else
                c_hintMenu.SetActive(true);
        }

    }

    private void Start()
    {
        isAlice = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            c_hintMenu.SetActive(false);
            a_hintMenu.SetActive(false);

            if (isAlice == false)
                isAlice = true;
            else if (isAlice == true)
                isAlice = false;
        }


        if (Input.GetKeyDown(KeyCode.H))
        {
            CheckActive();
        }
    }

}
