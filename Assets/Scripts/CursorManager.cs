using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// Referenced from https://www.youtube.com/watch?v=JybecYyj83k

public class CursorManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public SwitchManager switchManager;
    public Sprite aliceSprite;
    public Sprite alicePointerSprite;
    public Sprite aliceShapeSprite;
    public Sprite constanceSprite;
    public Sprite constancePointerSprite;
    public Sprite constanceShapeSprite;

    private Vector3 hotspot = new Vector3(35.0f, -40.0f, 0.0f);
    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition + hotspot;
    }

    //change to hand when hovering over buttons
    public void OnPointerEnter(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? alicePointerSprite : constancePointerSprite;
    }

    //change back to regular cursor when leaving
    public void OnPointerExit(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }

    //change to shape sprite when mouse is down
    public void OnPointerDown(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceShapeSprite : constanceShapeSprite;
    }

    //change back to regular cursor when click is released
    public void OnPointerUp(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }
}
