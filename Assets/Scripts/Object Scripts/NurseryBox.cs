using UnityEngine;

public class NurseryBox : MonoBehaviour
{
    public PuzzleControl4 puzzleControl;
    public Sprite openSprite;
    private SpriteRenderer spriteRenderer;
    [SerializeField]public GameObject boxClosed;
    [SerializeField]public GameObject boxOpen;


    [Header("The Password")]
    public GameObject[] correctOrder = new GameObject[3];

    [Header("The Current Attempt")]
    public GameObject[] selectedKeys = new GameObject[3];
    public int clickedKeys = 0;

    [Header("Lock Locations")]
    public Transform[] visualSlots; // The 3 keyhole/lock positions

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void AddKeyToLock(GameObject keyObject)
    {
        if (clickedKeys < 3)
        {
            selectedKeys[clickedKeys] = keyObject;

            KeyClick keyScript = keyObject.GetComponent<KeyClick>();

            // 1. Move the key in the Hierarchy to be a child of the Slot
            keyScript.lockVisual.transform.SetParent(visualSlots[clickedKeys]);
            keyScript.lockVisual.transform.localPosition = Vector3.zero;

            clickedKeys++;

            if (clickedKeys == 3) Invoke("CheckResult", 0.5f);
        }
    }

    void CheckResult()
    {
        int score = 0;
        for (int i = 0; i < 3; i++)
        {
            if (selectedKeys[i] == correctOrder[i]) score++;
        }

        if (score == 3)
        {
            spriteRenderer.sprite = openSprite;
            puzzleControl.allKeysFound = true;
            //puzzleControl.escapeRoomsComplete++;
            Debug.Log("Box Unlocked!");
            //chestClosed
            boxOpen.SetActive(true); 
            boxClosed.SetActive(false);
            puzzleControl.Back4.SetActive(true); // this is turning off the popup background and idk why
        }
        else
        {
            ResetPuzzle();
        }
    }

    public void ResetPuzzle()
    {
        for (int i = 0; i < 3; i++)
        {
            if (selectedKeys[i] != null)
            {
                // Tell the key to go back to its original spot in the box
                selectedKeys[i].GetComponent<KeyClick>().ReturnToBox();
                selectedKeys[i] = null;
            }
        }
        clickedKeys = 0;
    }
}