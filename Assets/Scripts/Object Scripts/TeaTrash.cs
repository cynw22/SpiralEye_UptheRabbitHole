using UnityEngine;

public class TeaTrash : MonoBehaviour
{
    [SerializeField] public Teapot teapot;
    [SerializeField] public IngredientPot[] pots;

    private void OnMouseDown()
    {
        teapot.ClearTeapot();
        for (int i = 0; i < pots.Length; i++)
        {
            pots[i].spriteRenderer.sprite = pots[i].sprite1;
        }
    }
}
