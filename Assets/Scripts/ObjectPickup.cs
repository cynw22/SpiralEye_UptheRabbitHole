using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class ObjectPickup : MonoBehaviour, IPointerDownHandler
{
    public SwitchManager switchManager;
    [SerializeField] public PuzzleControl2 puzzleManager;

    // public Sprite spritePickedUp;
    // private Image image;

    private bool beenClicked;

    public bool interactableWithAlice;
    public bool interactableWithConstance;

    [SerializeField] ItemToFind item;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beenClicked = false;
        // interactableWithAlice = true;
        // interactableWithConstance = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (beenClicked == true)
        {
            // image.sprite = spritePickedUp;
            puzzleManager.findObject(item);
            gameObject.SetActive(false);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //alice's perspective
        if (switchManager.sisterPOV == false)
        {
            if (interactableWithAlice == true)
            {
                beenClicked = true;
                Debug.Log(item + " Picked Up");
            }

            else if (interactableWithAlice == false)
            {
                beenClicked = false;
            }
        }

        //constance's perspective
        if (switchManager.sisterPOV == true)
        {
            if (interactableWithConstance == true)
            {
                beenClicked = true;
                Debug.Log(item + " Picked Up");
            }

            else if (interactableWithConstance == false)
            {
                beenClicked = false;
            }
        }
    }
}
