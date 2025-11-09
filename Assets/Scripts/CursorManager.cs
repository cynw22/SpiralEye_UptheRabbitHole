using UnityEngine;
using UnityEngine.UI;

// Referenced from https://www.youtube.com/watch?v=JybecYyj83k

public class CursorManager : MonoBehaviour
{
    public SwitchManager switchManager;
    public Sprite aliceSprite;
    public Sprite constanceSprite;

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
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }
}
