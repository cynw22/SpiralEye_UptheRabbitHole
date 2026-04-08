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

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("Levels");
    }

    // Tutorial:
    
    public void TutDrinkMe()
    {
        SceneManager.LoadScene("TalkingTutorial");
    }
    
    public void TutorialLevel()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void CatLevel() {

            SceneManager.LoadScene("MeetCat");
    }

    public void CatChoice()
    {

        SceneManager.LoadScene("MeetCatPuzzle"); // change it when it gets changed
    }

    public void CatEnd()
    {

        SceneManager.LoadScene("PartyFight"); // change it when it gets changed
    }
    // Level 2 

    public void MadHatterTalk()
    {

        SceneManager.LoadScene("MadHatterTalking");
    }

    public void MadHatterLevel()
    {

        SceneManager.LoadScene("MadHatter");
    }

    public void teaMiniGame()
    {
        SceneManager.LoadScene("MadHatterPuzzle");
    }

    //WhiteRabbit
    public void WhiteRabbitHouseOutside()
    {
        SceneManager.LoadScene("WhiteRabbitHouse");
    }

    public void WhiteRabbitHouseInside()
    {
        SceneManager.LoadScene("WhiteRabbitPuzzle");
    }

    public void ThePoster()
    {
        SceneManager.LoadScene("ThePoster");
    }

    public void TheGate()
    {
        SceneManager.LoadScene("TheGate");
    }


    public void QueenLevel()
    {

        SceneManager.LoadScene("FindTheRose");
    }


    public void GardenPartyTalk()
    {

        SceneManager.LoadScene("GardenPartyTalk");
    }

    public void QueensCourt()
    {

        SceneManager.LoadScene("QueenCourt");
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

    public void GoodEnd1() {
        SceneManager.LoadScene("GoodCut1");
    }

    //ChangeLater
    public void GoodEnd2()
    {
        SceneManager.LoadScene("GoodCut3");
    }

    public void GoodEnd3()
    {
        SceneManager.LoadScene("GoodCut3");
    }

}
