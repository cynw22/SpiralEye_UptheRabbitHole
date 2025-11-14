using UnityEngine;
using UnityEngine.UI;

// Getting text from an input field - https://discussions.unity.com/t/get-text-from-input-field-in-c/129605/6

public class CookieChest : MonoBehaviour
{
    public PuzzleControl1 puzzleControl;
    public Sprite closeSprite;
    public Sprite openSprite;
    public GameObject chestInput;

    private Image image;

    public bool isOpen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chestInput.GetComponent<Text>();
        image = GetComponent<Image>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = isOpen == false ? closeSprite : openSprite;
    }
}
