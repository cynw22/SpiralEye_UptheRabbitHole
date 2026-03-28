using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CursorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public SwitchManager switchManager;

    public Sprite aliceSprite;
    public Sprite alicePoint;
    public Sprite aliceClick;
    public Sprite constanceSprite;
    public Sprite constancePoint;
    public Sprite constanceClick;

    private Image image;

    bool hovering;
    bool mouseDown;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Image>();
        image.sprite = constanceSprite;
        hovering = false;
        mouseDown = false;
    }

    void Update()
    {
        if (!hovering && !mouseDown)
        {
            image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
            Debug.Log("Mouse not down or hovering");
        }

        else if (hovering && !mouseDown)
        {
            image.sprite = switchManager.sisterPOV == false ? alicePoint : constancePoint;
            Debug.Log("Mouse hovering");
        }
        
        else if (hovering && mouseDown)
        {
            image.sprite = switchManager.sisterPOV == false ? aliceClick : constanceClick;
            Debug.Log("Mouse down");
        }

        else if (!hovering && mouseDown)
        {
            image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
            Debug.Log("Clicking but not hovering");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovering = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseDown = false;
    }
}
