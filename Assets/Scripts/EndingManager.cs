using UnityEngine;
using UnityEngine.SceneManagement;

//Cutscene Manager: https://docs.unity3d.com/6000.2/Documentation/Manual/scenes-working-with.html and https://discussions.unity.com/t/how-to-make-a-picture-cutscene/206005

[RequireComponent(typeof(SoundFXManager))]

public class EndingManager : MonoBehaviour
{
    public GameObject[] page;
    private int currentPages = 0;

    [SerializeField] private AudioClip pageFlipping;
    [SerializeField] private AudioClip backingTrack;
    private SoundFXManager sound;
    void Start()
    {
        ShowEndingPage(0);
        sound = GetComponent<SoundFXManager>();
        sound.PlayLoop(backingTrack);
    }

    public void NextEndingPage()
    {
        // If we’re on the last page this should load main menu
        if (currentPages == page.Length - 1)
        {
            sound.PlaySound(pageFlipping);
            sound.StopLoop();
            ReturnToMenu();
            return;
        }

        sound.PlaySound(pageFlipping);
        currentPages++;
        ShowEndingPage(currentPages);
    }

    public void PreviousEndingPage()
    {
        if (currentPages <= 0) return;
        sound.PlaySound(pageFlipping);
        currentPages--;
        ShowEndingPage(currentPages);
    }

    private void ShowEndingPage(int index)
    {
        for (int i = 0; i < page.Length; i++)
        {
            page[i].SetActive(i == index);
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0); // Scene 0 = Main Menu
    }
}