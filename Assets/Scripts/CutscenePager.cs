using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//Cutscene Manager: https://docs.unity3d.com/6000.2/Documentation/Manual/scenes-working-with.html and https://discussions.unity.com/t/how-to-make-a-picture-cutscene/206005

[RequireComponent(typeof(SoundFXManager))]

public class CutscenePager : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPage = 0;

    [Header("Buttons")]
    public Button previousButton;
    public Button nextButton;

    [SerializeField] private AudioClip pageFlip;
    [SerializeField] private AudioClip backTrack;
    
    private SoundFXManager soundHelper;
    void Start()
    {
        ShowPage(0);
        soundHelper = GetComponent<SoundFXManager>();
        soundHelper.PlayLoop(backTrack);
        ShowPage(0);
        UpdateButtonStates();
    }

    public void NextPage()
    {
        soundHelper.PlaySound(pageFlip);

        // If we’re on the last page, start the game
        if (currentPage >= pages.Length - 1)
        {
            StartGame();
            soundHelper.StopLoop();
            return;
        }

        currentPage++;
        ShowPage(currentPage);
        UpdateButtonStates();
    }

    public void PreviousPage()
    {
        if (currentPage <= 0) return;
        soundHelper.PlaySound(pageFlip);
        currentPage--;
        ShowPage(currentPage);
        UpdateButtonStates();
    }

    private void ShowPage(int index)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i == index);
        }
    }

    private void UpdateButtonStates()
    {
        // Previous is greyed out on first page
        if (previousButton != null)
            previousButton.interactable = currentPage > 0;

        // Next is always interactable
        if (nextButton != null)
            nextButton.interactable = true;
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