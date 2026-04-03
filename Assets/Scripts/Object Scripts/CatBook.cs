using UnityEngine;

public class CatBook : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;

    [SerializeField] public Sprite shelf, catBook;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = shelf;
    }

    private void OnMouseDown()
    {
        spriteRenderer.sprite = catBook;
        if (!puzzleControl.catBookFound)
        {
            puzzleControl.escapeRoomsComplete++;
        }
        puzzleControl.catBookFound = true;
    }
}
