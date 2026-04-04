using UnityEngine;

public class KeyClick : MonoBehaviour
{
    public NurseryBox box;

    [Header("Visual States")]
    public GameObject boxVisual;  // Drag the 'BoxVisual' child here
    public GameObject lockVisual; // Drag the 'LockVisual' child here

    private Vector3 originalPosition;
    private Transform originalParent;
    private bool isLocked = false;

    void Start()
    {
        originalPosition = transform.position;
        originalParent = transform.parent;
        InitialVisualSetup();
    }

    // Adding this ensures that even if you reset the puzzle, the visuals stay correct
    void OnEnable()
    {
        InitialVisualSetup();
    }

    void InitialVisualSetup()
    {
        if (boxVisual != null) boxVisual.SetActive(true);
        if (lockVisual != null) lockVisual.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (!isLocked && box.clickedKeys < 3)
        {
            isLocked = true;

            // Switch the look
            boxVisual.SetActive(false);
            lockVisual.SetActive(true);

            box.AddKeyToLock(this.gameObject);
            Debug.Log(gameObject.name + " clicked. Sending to slot: " + box.clickedKeys);
        }
    }

    public void ReturnToBox()
    {
        isLocked = false;

        // Switch the look back
        boxVisual.SetActive(true);
        lockVisual.SetActive(false);

        transform.SetParent(originalParent);
        transform.position = originalPosition;
    }
}