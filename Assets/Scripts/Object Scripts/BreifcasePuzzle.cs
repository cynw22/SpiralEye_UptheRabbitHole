using UnityEngine;
using UnityEngine.UI;

// Getting text from an input field - https://discussions.unity.com/t/get-text-from-input-field-in-c/129605/6

public class BreifcasePuzzle : MonoBehaviour
{
    public PuzzleControl4 puzzleControl;

    private SpriteRenderer spriteRenderer;
    public Sprite closeSprite;
    public Sprite openSprite;

    public LetterCycler[] letters;

    [SerializeField] public GameObject cookies;
    GameObject breifcase;
    [SerializeField] public GameObject nonCookies;

    public Collider2D col;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cookies.SetActive(false);
        breifcase = GameObject.Find("BreifcasePopup");
        col = GetComponent<Collider2D>();
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
            puzzleControl.suitcaseIsOpen = true;
            spriteRenderer.sprite = openSprite;
            cookies.SetActive(true);
            nonCookies.SetActive(false);
            //puzzleControl.escapeRoomsComplete++;
            col.enabled = false;
            puzzleControl.Back2.SetActive(true);


        }
    }
}
