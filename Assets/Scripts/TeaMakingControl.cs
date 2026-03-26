using UnityEngine;
using System.Collections.Generic;

public enum Ingredients { GUMDROPS, MILK, PETALS, BUBBLES };

public class TeaMakingControl : MonoBehaviour
{
    [SerializeField] public SwitchManager switchManager;

    [SerializeField] public GameObject conEnv;
    [SerializeField] public GameObject aliceEnv;

    // Tea Sequences
    public List<Ingredients> floralTea;
    public List<Ingredients> roundTea;
    public List<Ingredients> simpleTea;
    public List<Ingredients> specialTea;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        floralTea = new List<Ingredients>();
        floralTea.Add(Ingredients.GUMDROPS);
        floralTea.Add(Ingredients.PETALS);
        floralTea.Add(Ingredients.MILK);

        roundTea = new List<Ingredients>();
        floralTea.Add(Ingredients.BUBBLES);
        floralTea.Add(Ingredients.MILK);
        floralTea.Add(Ingredients.GUMDROPS);

        simpleTea = new List<Ingredients>();
        floralTea.Add(Ingredients.MILK);
        floralTea.Add(Ingredients.GUMDROPS);

        specialTea = new List<Ingredients>();
        floralTea.Add(Ingredients.PETALS);
        floralTea.Add(Ingredients.GUMDROPS);
        floralTea.Add(Ingredients.BUBBLES);
    }

    // Update is called once per frame
    void Update()
    {
        setEnvironment();
    }

    void setEnvironment()
    {
        if (switchManager.sisterPOV)
        {
            conEnv.SetActive(true);
            aliceEnv.SetActive(false);
        }
        else
        {
            conEnv.SetActive(false);
            aliceEnv.SetActive(true);
        }
    }
}
