using UnityEngine;
using UnityEngine.UI;

// Getting text from an input field - https://discussions.unity.com/t/get-text-from-input-field-in-c/129605/6

public class CookieChest : MonoBehaviour
{
    public PuzzleControl1 puzzleControl;

    private SpriteRenderer spriteRenderer;
    public Sprite closeSprite;
    public Sprite openSprite;

    public LetterCycler[] letters;

    public bool isOpen = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = isOpen == false ? closeSprite : openSprite;
    }
}
