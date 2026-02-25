using UnityEngine;

public class DrinkMeBottles : MonoBehaviour
{
    public bool isSafe = false;
    [SerializeField] Bookshelf bookshelf;
    [SerializeField] public SwitchManager switchManager;

    [SerializeField] public Sprite bottleSprite;
    [SerializeField] public Sprite safeSprite;
    [SerializeField] public Sprite unsafeSprite;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (switchManager.sisterPOV == true)
        {
            spriteRenderer.sprite = isSafe ? safeSprite : unsafeSprite;
        }
        else
        {
            spriteRenderer.sprite = bottleSprite;
        }
    }

    private void OnMouseDown()
    {
        if (isSafe)
        {
            bookshelf.numFoundBottles++;
            gameObject.SetActive(false);
        }
    }
}
