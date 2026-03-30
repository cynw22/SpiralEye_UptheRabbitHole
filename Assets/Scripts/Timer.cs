using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI timeLeft;
    public float seconds;
    public float minutes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        time = 300;
        seconds = 0;
        minutes = 0;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        minutes = time / 60;
        seconds = time % 60;
        timeLeft.text = "Time Left: " + Mathf.Floor(minutes).ToString() + ":" + Mathf.Floor(seconds).ToString();
    }
}
