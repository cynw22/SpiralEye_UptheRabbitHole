using UnityEngine;

public class Carpet : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;
    public SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite sprite1, sprite2, sprite3;
    int timesClicked;

    public Collider2D col;
    [SerializeField] public GameObject popupBG;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
        timesClicked = 0;

        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        col.enabled = (popupBG.activeSelf ? false : true);
    }

    private void OnMouseDown()
    {
        if (timesClicked == 0)
        {
            spriteRenderer.sprite = sprite2;
        }
        if (timesClicked == 1)
        {
            puzzleControl.numNewsFound++;
            if (puzzleControl.numNewsFound == puzzleControl.numNews && !puzzleControl.allNewsFound)
            {
                puzzleControl.CompleteNewspaper();
            }

            spriteRenderer.sprite = sprite3;
        }
        else if (timesClicked >= 20)
        {
            Application.OpenURL("https://bsky.app/profile/tobyfox.undertale.com/post/3l7gxx7iajb2a");
        }

        timesClicked++;
    }
}