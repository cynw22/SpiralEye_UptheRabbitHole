using UnityEngine;

public class Newspaper : MonoBehaviour
{
    [SerializeField] public PuzzleControl4 puzzleControl;
    private Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnMouseDown()
    {
        puzzleControl.escapeRoomsComplete++;
        col.enabled = false;
    }
}
