using UnityEngine;

public class ExplanationPopup : MonoBehaviour
{
    [SerializeField] public GameObject toDisplay;
    [SerializeField] public GameObject AliceDialouge;
    [SerializeField] public GameObject ConstanceDialouge;
    [SerializeField] public GameObject NarrativeDialouge;
    [SerializeField] public GameObject TutorialDialouge;
    [SerializeField] public GameObject ChoiceRoot;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alice" + AliceDialouge.activeSelf.ToString());
        Debug.Log("Constance" + ConstanceDialouge.activeSelf.ToString());
        Debug.Log("Narrator" + NarrativeDialouge.activeSelf.ToString());
        Debug.Log("Tutorial" + TutorialDialouge.activeSelf.ToString());
        Debug.Log("Choice" + ChoiceRoot.activeSelf.ToString());
        if ((!AliceDialouge.activeSelf)&&(!ConstanceDialouge.activeSelf)&&(!NarrativeDialouge.activeSelf)&&(!TutorialDialouge.activeSelf)&&(!ChoiceRoot.activeSelf))
        {
            toDisplay.SetActive(true);
        }
    }
}
