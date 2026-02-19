using UnityEngine;
using UnityEngine.UI;

public class SwitchPopup : MonoBehaviour
{
    public SwitchManager switchManager;
    public Sprite aliceSprite;
    public Sprite constanceSprite;

    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }
}
