using UnityEngine;

public class Newspaper : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;
    private Collider2D col;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        col = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        puzzleControl.escapeRoomsComplete++;
        col.enabled = false;
        spriteRenderer.enabled = false;
    }
}
