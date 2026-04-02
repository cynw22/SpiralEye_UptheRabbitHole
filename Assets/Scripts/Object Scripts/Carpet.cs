using UnityEngine;

public class Carpet : MonoBehaviour
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

    private void Update()
    {
        if (timesClicked == 1)
        {
            spriteRenderer.sprite = sprite2;
        }
        else if (timesClicked >= 2)
        {
            spriteRenderer.sprite = sprite3;
        }
    }

    private void OnMouseDown()
    {
        if (timesClicked == 1)
        {
            puzzleControl.numNewsFound++;
            if (puzzleControl.numNewsFound == puzzleControl.numNews)
            {
                puzzleControl.allNewsFound = true;
                puzzleControl.completePaper.SetActive(true);
            }
        }
        else if (timesClicked >= 20)
        {
            Application.OpenURL("https://bsky.app/profile/tobyfox.undertale.com/post/3l7gxx7iajb2a");
        }

        timesClicked++;
    }
}