using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

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

    int timesWrong = 0;

    [Header("Tea Popups")]
    public GameObject floralTeaPopup;
    public GameObject roundTeaPopup;
    public GameObject simpleTeaPopup;
    public GameObject specialTeaPopup;
    public GameObject wrongTeaPopup; // For when the combination is wrong
    public GameObject wrongIngredientsPopup;
    public GameObject winScreenPopup;
    public GameObject loseScreenPopup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Popups set not active  
        SetPopupsOff();

        floralTea = new List<Ingredients>();
        floralTea.Add(Ingredients.GUMDROPS);
        floralTea.Add(Ingredients.PETALS);
        floralTea.Add(Ingredients.MILK);

        roundTea = new List<Ingredients>();
        roundTea.Add(Ingredients.BUBBLES);
        roundTea.Add(Ingredients.MILK);
        roundTea.Add(Ingredients.GUMDROPS);

        simpleTea = new List<Ingredients>();
        simpleTea.Add(Ingredients.MILK);
        simpleTea.Add(Ingredients.GUMDROPS);

        specialTea = new List<Ingredients>();
        specialTea.Add(Ingredients.PETALS);
        specialTea.Add(Ingredients.GUMDROPS);
        specialTea.Add(Ingredients.BUBBLES);
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

    public bool checkTea(List<Ingredients> submittedTea)
    {
        Debug.Log("checking...");
        bool correctTea = false;

        // check if length of lists match
        if (desiredTea == 0 && submittedTea.Count == floralTea.Count)
        {
            // check contents of lists against each other
            for (int i = 0; i < submittedTea.Count; i++)
            {
                // break if contents are wrong
                if (submittedTea[i] != floralTea[i])
                {
                    Debug.Log("wrong tea submission");
                    wrongTeaPopup.SetActive(true);
                    timesWrong++;
                    break;
                }

                correctTea = i == submittedTea.Count - 1 ? true : false;
                Debug.Log("correct tea submission - floral tea");
                floralTeaPopup.SetActive(true);
            }
        }
        else if (desiredTea == 1 && submittedTea.Count == roundTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != roundTea[i]) { wrongTeaPopup.SetActive(true); break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
                roundTeaPopup.SetActive(true);
            }
        }
        else if (desiredTea == 2 && submittedTea.Count == simpleTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != simpleTea[i])
                {
                    Debug.Log("simple tea failed");
                    wrongTeaPopup.SetActive(true);
                    timesWrong++;
                    break;
                }
                correctTea = i == submittedTea.Count - 1 ? true : false;
                simpleTeaPopup.SetActive(true);
            }
        }
        else if (desiredTea == 3 && submittedTea.Count == specialTea.Count)
        {
            for (int i = 0; i < submittedTea.Count; i++)
            {
                if (submittedTea[i] != specialTea[i]) { wrongTeaPopup.SetActive(true); break; }
                correctTea = i == submittedTea.Count - 1 ? true : false;
                winScreenPopup.SetActive(true);
                //To Change Later
                SceneManager.LoadScene("WhiteRabbitPuzzle"); // switch later
            }
        }
        //else if (desiredTea == 4) {
        //    Debug.Log("All Four Teas Found");
        //    winScreenPopup.SetActive(true);
        //}
        else
        {
            Debug.Log("wrong amount of ingredients submitted");
            wrongIngredientsPopup.SetActive(true);
        }

        if (timesWrong >= 3)
        {
            loseScreenPopup.SetActive(true);
        }

        if (correctTea)
        {
            desiredTea++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetPopupsOff() {
        floralTeaPopup.SetActive(false);
        roundTeaPopup.SetActive(false);
        simpleTeaPopup.SetActive(false);
        specialTeaPopup.SetActive(false);
        wrongIngredientsPopup.SetActive(false);
        wrongTeaPopup.SetActive(false);
        winScreenPopup.SetActive(false);
        loseScreenPopup.SetActive(false);
    }
}
