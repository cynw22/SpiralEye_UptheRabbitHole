using UnityEngine;

public class NurseryBox : MonoBehaviour
{
    public PuzzleControl4 puzzleControl;
    private SpriteRenderer spriteRenderer;
    public Sprite closeSprite;
    public Sprite openSprite;

    public GameObject[] keys;

    public GameObject[] selectedKeys;

    public int clickedKeys;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        selectedKeys = new GameObject[3];
        clickedKeys = 0;
    }

    public void checkKey()
    {
        int correctKeys = 0;
        if (clickedKeys == 3) {
            for (int i = 0; i < puzzleControl.numKeys; i++)
            {
                if (keys[i] == selectedKeys[i])
                {
                    correctKeys++;
                    Debug.Log("correct keys: " + correctKeys);
                }
            }

            if (correctKeys == 3)
            {
                puzzleControl.allKeysFound = true;
                spriteRenderer.sprite = openSprite;
            }

            else if (correctKeys < 3)
            {
                Debug.Log("Incorrect Combination");
                for (int i = 0; i < puzzleControl.numKeys; i++)
                {
                    selectedKeys[i] = null;
                }
                clickedKeys = 0;
            }
        }
    }
}
