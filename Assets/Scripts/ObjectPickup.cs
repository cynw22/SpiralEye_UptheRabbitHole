using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class ObjectPickup : MonoBehaviour, IPointerDownHandler
{
    public SwitchManager switchManager;

    public Sprite spritePickedUp;

    private Image image;

    private bool beenClicked;

    public bool interactableWithAlice;
    public bool interactableWithConstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beenClicked = false;
        interactableWithAlice = true;
        interactableWithConstance = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (beenClicked == true)
        {
            image.sprite = spritePickedUp;
            Debug.Log("Object Picked Up");
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
            }

            else if (interactableWithConstance == false)
            {
                beenClicked = false;
            }
        }
    }
}
