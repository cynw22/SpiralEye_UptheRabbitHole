using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public SwitchManager switchManager;
    public Sprite aliceSprite;
    public Sprite constanceSprite;

    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = switchManager.sisterPOV == false ? aliceSprite : constanceSprite;
    }
}
