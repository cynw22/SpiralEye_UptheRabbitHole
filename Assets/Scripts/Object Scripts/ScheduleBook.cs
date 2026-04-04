using UnityEngine;

public class ScheduleBook : MonoBehaviour
{
    [Header("Page Sprites")]
    [SerializeField] public Sprite[] pages;
    //[SerializeField] public Sprite page1, page2, page3;
    private SpriteRenderer spriteRenderer;
    private int currentPageIndex = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdatePageVisual();
        //spriteRenderer.sprite = page1;

    }

    public void FlipForward() { 
        if (currentPageIndex < pages.Length -1) {
            currentPageIndex++;
            UpdatePageVisual();
        }
    }

    public void FlipBackwards()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            UpdatePageVisual();
        }
    }

    void UpdatePageVisual() {
        if (pages.Length > 0 && spriteRenderer != null)
        {
            spriteRenderer.sprite = pages[currentPageIndex];
        }
    }

    ////Called by left / right buttons
    //public void FlipPage(int direction)
    //{
    //    //direction 1 = forward, -1 = backwards
    //    int nextPageIndex = currentPageIndex + direction;

    //    // Prevent Flipping past the first or last page
    //    if (nextPageIndex >= 0 && nextPageIndex < pages.Length)
    //    {
    //        currentPageIndex = nextPageIndex;
    //        UpdatePageVisual();
    //        Debug.Log("Current Page " + (currentPageIndex + 1));
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    if (spriteRenderer.sprite == page1)
    //    {
    //        Debug.Log("pg 1 -> 2");
    //        spriteRenderer.sprite = page2;
    //    }
    //    else if (spriteRenderer.sprite == page2)
    //    {
    //        Debug.Log("pg 2 -> 3");
    //        spriteRenderer.sprite = page3;
    //    }
    //    else
    //    {
    //        spriteRenderer.sprite = page1;
    //    }
    //}
}
