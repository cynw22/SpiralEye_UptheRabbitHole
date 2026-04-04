//using UnityEngine;

//public class KeyClick : MonoBehaviour
//{
//    public NurseryBox chest;

//    bool isClicked;

//    // Update is called once per frame
//    void OnMouseDown()
//    {
//        if (chest.selectedKeys[chest.clickedKeys] == null && isClicked == false)
//        {
//            chest.selectedKeys[chest.clickedKeys] = gameObject;
//            chest.clickedKeys++;
//            isClicked = true;

//            if (chest.clickedKeys == 3)
//            {
//                chest.checkKey();
//            }
//        }
//    }

//    void Update()
//    {
//        if (chest.clickedKeys == 0)
//        {
//            isClicked = false;
//        }
//    }
//}

using UnityEngine;

public class KeyCodeinLock : MonoBehaviour
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

        // Ensure only the box look is showing at start
        if (boxVisual) boxVisual.SetActive(true);
        if (lockVisual) lockVisual.SetActive(false);
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