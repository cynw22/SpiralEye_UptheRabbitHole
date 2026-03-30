using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] int LevelNumber;
    public TextMeshProUGUI timeLeft;
    public float seconds;
    public float minutes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        seconds = 0;
        minutes = 0;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 1) {
            if (LevelNumber == 4) // 4 = White Rabbit House
            {
                SceneManager.LoadScene("ThePoster");
            }
            if (LevelNumber == 5) { // 5 = FindTheRose
                SceneManager.LoadScene("FindTheRose"); //Change Later to Queens Court
            }
        }
        minutes = time / 60;
        seconds = time % 60;
        if (seconds >= 10) { 
            timeLeft.text = "Time Left: " + Mathf.Floor(minutes).ToString() + ":" + Mathf.Floor(seconds).ToString();
        }
        else
            timeLeft.text = "Time Left: " + Mathf.Floor(minutes).ToString() +":0" + Mathf.Floor(seconds).ToString();
    }
}
