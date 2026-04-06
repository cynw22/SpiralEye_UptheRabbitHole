using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.InputSystem;

public class Pause_Script : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] bool isReverse;

    void Start() {
        if (!isReverse)
        {
            Time.timeScale = 0.0f;
        }
        else
            Time.timeScale = 1.0f;

    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        
            Time.timeScale = 0f;
        

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
            Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);

    }

    void Update()
    {
        
        if (!isReverse)
        {
            if ((Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.P))))
            {
                if (pauseMenu.active)
                    Resume();
                else
                    Pause();
            }

            var gamepad = Gamepad.current;

            if (gamepad != null && gamepad.startButton.wasPressedThisFrame)
            {
                if (pauseMenu.active)
                    Resume();
                else
                    Pause();
            }
        }
    }

}
