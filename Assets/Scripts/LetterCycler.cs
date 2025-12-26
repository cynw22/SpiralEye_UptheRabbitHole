using UnityEngine;

public class LetterCycler : MonoBehaviour
{
    public int currLetter = 0;
    
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // clamp letters
        if (currLetter <= -1)
        {
            currLetter = sprites.Length - 1;
        }
        else if (currLetter >= sprites.Length)
        {
            currLetter = 0;
        }

        // set correct letter sprite
        spriteRenderer.sprite = sprites[currLetter];
    }
}
