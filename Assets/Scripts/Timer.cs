using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI timeLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        time = 300;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeLeft.text = "Time Left: " + Mathf.Floor(time).ToString() + " seconds";
    }
}
