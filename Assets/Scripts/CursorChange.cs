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
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Image>();
        image.sprite = constanceSprite;
    }

    void Update()
    {
        var switchControl = UserInput.instance.controls.Player.Switch;
        if (switchControl.WasPressedThisFrame())
        {
            image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? alicePoint : constancePoint;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceClick : constanceClick;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }
}
