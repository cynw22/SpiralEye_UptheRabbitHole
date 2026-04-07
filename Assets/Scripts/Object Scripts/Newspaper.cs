using UnityEngine;

public class Newspaper : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;
    private Collider2D col;
    private SpriteRenderer spriteRenderer;
    private Popup popup;

    private void Start()
    {
        col = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        popup = GetComponent<Popup>();
    }

    private void OnMouseDown()
    {
        col.enabled = false;
        spriteRenderer.enabled = false;
        popup.ShowPopup();
    }
}
