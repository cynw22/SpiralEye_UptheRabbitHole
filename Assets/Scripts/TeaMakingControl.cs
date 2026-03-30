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

    public int desiredTea = 0;

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

    public void checkTea(List<Ingredients> submittedTea)
    {
        Debug.Log("checking...");
        bool correctTea = false;

        if (desiredTea == 0 && submittedTea.Count == floralTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != floralTea[i]) {
                    Debug.Log("wrong tea submission");
                    break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
                Debug.Log("correct tea submission");
            }
        }
        else if (desiredTea == 1 && submittedTea.Count == roundTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != roundTea[i]) { break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
            }
        }
        else if (desiredTea == 2 && submittedTea.Count == simpleTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != simpleTea[i]) { break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
            }
        }
        else if (desiredTea == 3 && submittedTea.Count == specialTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != specialTea[i]) { break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
            }
        }
        else
        {
            Debug.Log("wrong amount of ingredients submitted");
        }

        if (correctTea)
        {
            desiredTea++;
        }
    }
}
