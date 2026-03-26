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
    }

    protected void ClearTeapot()
    {
        addedIngredients.Clear();
        spriteRenderer.sprite = emptyBase;
    }

    public void SubmitTea()
    {

        ClearTeapot();
    }
}