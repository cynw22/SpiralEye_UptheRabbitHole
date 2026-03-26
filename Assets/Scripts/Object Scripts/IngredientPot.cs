using UnityEngine;

public class IngredientPot : MonoBehaviour
{
    [SerializeField] public Teapot teapot;
    [SerializeField] public Ingredients containedIngredient;

    public Sprite sprite1, sprite2;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
    }

    private void OnMouseDown()
    {
        teapot.AddIngredient(containedIngredient);
        spriteRenderer.sprite = sprite2;
    }
}
