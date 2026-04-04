using UnityEngine;

public class NurseryBox : MonoBehaviour
{
    public PuzzleControl4 puzzleControl;
    public Sprite openSprite;
    private SpriteRenderer spriteRenderer;

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
        // Safety: Don't do anything if we already have 3 keys
        if (clickedKeys >= 3) return;

        // Store the key in our attempt array
        selectedKeys[clickedKeys] = keyObject;

        // Determine which slot to move to based on the current count (0, 1, or 2)
        Transform targetSlot = visualSlots[clickedKeys];

        if (targetSlot != null)
        {
            // 1. Parent the key to the specific slot (Slot1, Slot2, or Slot3)
            keyObject.transform.SetParent(targetSlot);

            // 2. Snap to the center of THAT specific slot
            keyObject.transform.localPosition = Vector3.zero;
            keyObject.transform.localRotation = Quaternion.identity;
        }

        // 3. NOW increment the counter so the NEXT key goes to the NEXT slot
        clickedKeys++;

        // If we just added the 3rd key, check the result
        if (clickedKeys == 3)
        {
            Invoke("CheckResult", 0.5f);
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
            puzzleControl.escapeRoomsComplete++;
            Debug.Log("Box Unlocked!");
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