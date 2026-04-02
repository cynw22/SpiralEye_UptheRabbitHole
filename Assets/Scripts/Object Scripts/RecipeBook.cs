using UnityEngine;

public class RecipeBook : MonoBehaviour
{
    [SerializeField] public TeaMakingControl teaControl;
    [SerializeField] public Sprite recipe1, recipe2, recipe3, recipe4;
    protected SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = recipe1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (teaControl.desiredTea)
        {
            case 0:
                spriteRenderer.sprite = recipe1;
                break;
            case 1:
                spriteRenderer.sprite = recipe2;
                break;
            case 2:
                spriteRenderer.sprite = recipe3;
                break;
            case 3:
                spriteRenderer.sprite = recipe4;
                break;
            default:
                spriteRenderer.sprite = recipe1;
                break;
        }
    }
}
