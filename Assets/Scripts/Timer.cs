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
    [SerializeField] bool isCollected;

    [SerializeField] PuzzleControl5 PuzzleControl5;
    [SerializeField] PuzzleControl4 PuzzleControl4;
    [SerializeField] GameObject toDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        seconds = 0;
        minutes = 0;
        if (PuzzleControl5)
        {
            isCollected = PuzzleControl5.allObjectsFound;
            time = PuzzleControl5.time;
            LevelNumber = PuzzleControl5.levelNumber;
            toDisplay.SetActive(false);
        }
        else if (PuzzleControl4)
        {
            isCollected = PuzzleControl4.allObjectsFound;
            time = PuzzleControl4.time;
            LevelNumber = PuzzleControl4.levelNumber;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (PuzzleControl5)
        {
            isCollected = PuzzleControl5.allObjectsFound;
            time = PuzzleControl5.time;
            LevelNumber = PuzzleControl5.levelNumber;
        }
        else if (PuzzleControl4)
        {
            isCollected = PuzzleControl4.allObjectsFound;
            time = PuzzleControl4.time;
            LevelNumber = PuzzleControl4.levelNumber;
        }
        //Debug.Log(time);
        //time -= Time.deltaTime;

        if ((time <= 1) && (isCollected == false))
        {
            if (LevelNumber == 4) // 4 = White Rabbit House, Check if all the objects collected
            {
                toDisplay.SetActive(true);
                PuzzleControl4.isLoseDone = true;
            }
            if ((LevelNumber == 5) && (isCollected == false))
            { // 5 = FindTheRose, Check if all the Roses Collected
                //SceneManager.LoadScene("FindTheRoseTalk"); //Change Later to Queens Court
                toDisplay.SetActive(true);
            }
        }

            minutes = time / 60;
            seconds = time % 60;
            if (seconds >= 10)
            {
                timeLeft.text = "" + Mathf.Floor(minutes).ToString() + ":" + Mathf.Floor(seconds).ToString();
            }
            else
                timeLeft.text = "" + Mathf.Floor(minutes).ToString() + ":0" + Mathf.Floor(seconds).ToString();

            if (time <= 1)
            {
                timeLeft.text = "0:00";
                //if (LevelNumber == -1)
                //{
                //    SceneManager.LoadScene("ThePoster");//Remove later, this is for the poster
                //}
            }
        
    }
}
