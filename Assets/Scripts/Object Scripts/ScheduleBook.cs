using UnityEngine;

public class ScheduleBook : MonoBehaviour
{
    [SerializeField] public Sprite page1, page2, page3;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = page1;
    }

    private void OnMouseDown()
    {
        if (spriteRenderer.sprite == page1)
        {
            Debug.Log("pg 1 -> 2");
            spriteRenderer.sprite = page2;
        }
        else if (spriteRenderer.sprite == page2)
        {
            Debug.Log("pg 2 -> 3");
            spriteRenderer.sprite = page3;
        }
        else
        {
            spriteRenderer.sprite = page1;
        }
    }
}
