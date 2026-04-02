using UnityEngine;

public class Drawers : MonoBehaviour
{
    [SerializeField] public GameObject newsp;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        newsp.SetActive(false);
    }

    private void OnMouseDown()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
        newsp.SetActive(spriteRenderer.enabled ? true : false);
    }
}
