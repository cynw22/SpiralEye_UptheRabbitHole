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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        checkPassword();
    }

    public void checkPassword()
    {
        int correctLetters = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i].spriteRenderer.sprite == puzzleControl.passcodeLetters[i])
            {
                correctLetters++;
                Debug.Log("correct letters: " + correctLetters);
            }
        }

        if (correctLetters == 5)
        {
            puzzleControl.chestIsOpen = true;
            spriteRenderer.sprite = openSprite;
        }
    }
}
