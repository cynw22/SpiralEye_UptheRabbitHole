using UnityEngine;

public class NewspaperClip : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;

    //GameObject windowstillEnvironment;

    private void Start()
    {
        //windowstillEnvironment = puzzleControl.windowstillNewspaperEnvironment;
    }

    private void OnMouseDown()
    {
        puzzleControl.numNewsFound++;

        if (puzzleControl.numNewsFound == puzzleControl.numNews && !puzzleControl.allNewsFound)
        {
            puzzleControl.CompleteNewspaper();
        }

        //if (windowstillEnvironment != null)
        //{
        //    windowstillEnvironment.SetActive(false);
        //    Debug.Log("Window object picked up, environment closed");

        //}

        gameObject.SetActive(false);
    }
}
