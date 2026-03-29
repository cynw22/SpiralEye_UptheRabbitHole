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


    public void QueenLevel()
    {

        SceneManager.LoadScene("FindTheRose");
    }

    public void CatLevel() {

        SceneManager.LoadScene("MeetCat");
    }

    public void MadHatterLevel()
    {

        SceneManager.LoadScene("MadHatter");
    }

    public void TutorialLevel() {
        SceneManager.LoadScene("Tutorial");
    }

    public void LevelSelection() {
        SceneManager.LoadScene("Levels");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }


    public void tutDrinkMe() {
        SceneManager.LoadScene("TalkingTutorial");
    }

    public void teaMiniGame()
    {
        SceneManager.LoadScene("MadHatterPuzzle"); 
    }

    public void WhiteRabbitHouseOutside()
    {
        SceneManager.LoadScene("WhiteRabbitHouse");
    }

    public void WhiteRabbitHouseInside()
    {
        SceneManager.LoadScene("WhiteRabbitPuzzle");
    }

    public void TheGate() {
        SceneManager.LoadScene("TheGate");
    }

    //Endings
    public void BadEndOne() {
        SceneManager.LoadScene("Bad End One");
    }
    public void BadEndTwo()
    {
        SceneManager.LoadScene("Bad End Two");
    }
    public void BadEndThree()
    {
        SceneManager.LoadScene("Bad End Three");
    }
    public void BadEndFour()
    {
        SceneManager.LoadScene("Bad End Four");
    }

    public void BadEndFive()
    {
        SceneManager.LoadScene("Bad End Cat");
    }
    public void BadEndSix()
    {
        SceneManager.LoadScene("Bad End Queen");
    }


}
