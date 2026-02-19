using UnityEngine;

public class CyclerButton : MonoBehaviour
{
    public bool nextButton = true;
    public LetterCycler letter;

    private void OnMouseDown()
    {
        if (nextButton) { letter.currLetter++; } else { letter.currLetter--; }
    }
}
