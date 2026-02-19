using UnityEngine;
using UnityEngine.SceneManagement;

//Cutscene Manager: https://docs.unity3d.com/6000.2/Documentation/Manual/scenes-working-with.html and https://discussions.unity.com/t/how-to-make-a-picture-cutscene/206005

[RequireComponent(typeof(SoundFXManager))]

public class CutscenePager : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPage = 0;

    [SerializeField] private AudioClip pageFlip;
    [SerializeField] private AudioClip backTrack;
    private SoundFXManager soundHelper;
    void Start()
    {
        ShowPage(0);
        soundHelper = GetComponent<SoundFXManager>();
        soundHelper.PlayLoop(backTrack);
    }

    public void NextPage()
    {
        // If we’re on the last page this should load next scene
        if (currentPage == pages.Length - 1)
        {
            soundHelper.PlaySound(pageFlip);
            StartGame();
            soundHelper.StopLoop();
            return;
        }

        soundHelper.PlaySound(pageFlip);
        currentPage++;
        ShowPage(currentPage);
    }

    public void PreviousPage()
    {
        if (currentPage <= 0) return;
        soundHelper.PlaySound(pageFlip);
        currentPage--;
        ShowPage(currentPage);
    }

    private void ShowPage(int index)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i == index);
        }
    }

    public void StartGame()
    {
        // Load the next scene in Build Settings
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Safety check
        if (nextIndex < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(nextIndex);
        else
            Debug.LogWarning("No next scene in Build Settings!");
    }
}