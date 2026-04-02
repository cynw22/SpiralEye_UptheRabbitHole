using UnityEngine;

public class NewspaperClip : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;

    private void OnMouseDown()
    {
        puzzleControl.numNewsFound++;
        if (puzzleControl.numNewsFound == puzzleControl.numNews)
        {
            puzzleControl.allNewsFound = true;
            puzzleControl.completePaper.SetActive(true);
        }

        gameObject.SetActive(false);
    }
}
