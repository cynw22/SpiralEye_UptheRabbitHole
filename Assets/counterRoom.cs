using UnityEngine;

public class counterRoom : MonoBehaviour
{
    [SerializeField]PuzzleControl4 puzzleControl;
    private int checkCount;
    SpriteRenderer thisObject;
    [SerializeField] Sprite SwitchTo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        checkCount = 0;
        thisObject = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (checkCount == 0) { 
            puzzleControl.escapeRoomsComplete++;
            checkCount = 2;
            Debug.Log("Clicked on click count =2 ");
            if (SwitchTo) {
                thisObject.sprite = SwitchTo;
            }
        }
        Debug.Log("Clicked on != 0");
    }
}
