using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTrigger : MonoBehaviour
{
    [Header("Optional: Delay before loading next scene")]
    public float delay = 0f;

    private bool triggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return; // prevent double triggers
        if (!other.CompareTag("Player")) return;

        triggered = true;

        if (delay > 0f)
            Invoke(nameof(LoadNextScene), delay);
        else
            LoadNextScene();
    }

    private void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;

        int nextIndex = currentIndex + 1;

        if (nextIndex < totalScenes)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.Log("No more scenes! Returning to Main Menu.");
            SceneManager.LoadScene(0); // go back to menu
        }
    }
}