using UnityEngine;

public class WallDoors : MonoBehaviour
{
    [SerializeField] public SwitchManager switchManager;

    [SerializeField] public GameObject item;
    [SerializeField] public Sprite a_sprite;
    [SerializeField] public Sprite c_sprite;

    public SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        item.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = switchManager.sisterPOV ? c_sprite : a_sprite;
        if (switchManager.sisterPOV && spriteRenderer.enabled)
        {
            item.SetActive(true);
        }
        else
        {
            item.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}
