using UnityEngine;

public class ExplanationPopup : MonoBehaviour
{
    [SerializeField] public GameObject toDisplay;
    [SerializeField] public GameObject AliceDialouge;
    [SerializeField] public GameObject ConstanceDialouge;
    [SerializeField] public GameObject NarrativeDialouge;
    [SerializeField] public GameObject TutorialDialouge;
    [SerializeField] public GameObject ChoiceRoot;
    [SerializeField] public PopupBackground popupBackgroundButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Alice" + AliceDialouge.activeSelf.ToString());
        //Debug.Log("Constance" + ConstanceDialouge.activeSelf.ToString());
        //Debug.Log("Narrator" + NarrativeDialouge.activeSelf.ToString());
        //Debug.Log("Tutorial" + TutorialDialouge.activeSelf.ToString());
        //Debug.Log("Choice" + ChoiceRoot.activeSelf.ToString());

        if (!popupBackgroundButton.isActive)
        {
            if ((!AliceDialouge.activeSelf) && (!ConstanceDialouge.activeSelf) && (!NarrativeDialouge.activeSelf) && (!TutorialDialouge.activeSelf) && (!ChoiceRoot.activeSelf))
            {
                Debug.Log(popupBackgroundButton.isActiveAndEnabled);
                toDisplay.SetActive(true);

                Debug.Log("All Inactive");
            }
            Debug.Log("popupBackgroundButton is active and enabled");
        }
        else {
            toDisplay.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            toDisplay.SetActive(false);
            popupBackgroundButton.isActive = false;
        }

    }
}
