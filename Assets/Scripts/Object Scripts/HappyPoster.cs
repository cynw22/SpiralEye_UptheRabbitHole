using UnityEngine;

public class HappyPoster : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;
    public SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite sprite1, sprite2, sprite3;
    int timesClicked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
        timesClicked = 0;
    }

    private void OnMouseDown()
    {
        if (timesClicked == 0)
        {
            spriteRenderer.sprite = sprite2;
        }
        else if (timesClicked == 1)
        {
            puzzleControl.numNewsFound++;
            if (puzzleControl.numNewsFound == puzzleControl.numNews)
            {
                puzzleControl.allNewsFound = true;
                puzzleControl.completePaper.SetActive(true);
            }
            spriteRenderer.sprite = sprite3;
        }

        timesClicked++;
    }
}