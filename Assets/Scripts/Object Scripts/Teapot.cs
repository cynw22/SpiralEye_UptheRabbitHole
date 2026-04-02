using UnityEngine;
using System;
using System.Collections.Generic;

public class Teapot : MonoBehaviour
{
    [SerializeField] public TeaMakingControl teaControl;

    private List<Ingredients> addedIngredients;

    public SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite emptyBase, floralBase, roundBase, simpleBase, specialBase, mixing1, mixing2, mixing3, mixing4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        addedIngredients = new List<Ingredients>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void AddIngredient(Ingredients ing)
    {
        addedIngredients.Add(ing);
        switch (ing)
        {
            case Ingredients.PETALS:
                spriteRenderer.sprite = mixing1;
                break;
            case Ingredients.GUMDROPS:
                spriteRenderer.sprite = mixing2;
                break;
            case Ingredients.MILK:
                spriteRenderer.sprite = mixing3;
                break;
            case Ingredients.BUBBLES:
                spriteRenderer.sprite = mixing4;
                break;
        }
    }

    public void ClearTeapot()
    {
        addedIngredients.Clear();
        spriteRenderer.sprite = emptyBase;
    }

    public void SubmitTea()
    {
        bool correctTea = teaControl.checkTea(addedIngredients);
        ClearTeapot();

        if (correctTea)
        {
            switch (teaControl.desiredTea - 1)
            {
                case 0:
                    spriteRenderer.sprite = floralBase;
                    break;
                case 1:
                    spriteRenderer.sprite = roundBase;
                    break;
                case 2:
                    spriteRenderer.sprite = simpleBase;
                    break;
                case 3:
                    spriteRenderer.sprite = specialBase;
                    break;
                default:
                    spriteRenderer.sprite = emptyBase;
                    break;
            }
        }
    }
}