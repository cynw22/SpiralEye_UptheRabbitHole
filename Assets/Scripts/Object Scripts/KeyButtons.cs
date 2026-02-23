using UnityEngine;

public class KeyButtons : MonoBehaviour
{
    [SerializeField] private bool isDrinkMe;
    [SerializeField] public KeyBox keyBox;
    public Collider2D collider;

    private void Start()
    {
        collider = GetComponent<PolygonCollider2D>();
    }

    private void OnMouseDown()
    {
        keyBox.buttonPress(isDrinkMe == true ? 1 : 0);
        // Debug.Log("key button pressed");
    }
}
