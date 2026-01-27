using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EventManagerScript : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }

    public void SettingsPage()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void CreditsPage() {
        SceneManager.LoadScene("CreditsScene");
    
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }


}
