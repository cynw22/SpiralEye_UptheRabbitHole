using UnityEngine;

public class ExplanationPopup : MonoBehaviour
{
    [SerializeField] public GameObject toDisplay;
    [SerializeField] public GameObject AliceDialouge;
    [SerializeField] public GameObject ConstanceDialouge;
    [SerializeField] public GameObject NarrativeDialouge;
    [SerializeField] public GameObject TutorialDialouge;
    [SerializeField] public GameObject ChoiceRoot;

    // States: 0 = Waiting for dialogue, 1 = Popup is Open, 2 = Finished Forever
    private int popupState = 0;

    void Start()
    {
        toDisplay.SetActive(false);
        popupState = 0;
    }

    void Update()
    {
        // If we have already closed the popup (State 2), stop running logic entirely.
        if (popupState == 2) return;

        // Check if ANY dialogue is currently open
        bool anyDialogueOpen = AliceDialouge.activeSelf ||
                               ConstanceDialouge.activeSelf ||
                               NarrativeDialouge.activeSelf ||
                               TutorialDialouge.activeSelf ||
                               ChoiceRoot.activeSelf;

        // LOGIC: If we are waiting (State 0) AND no dialogues are open, OPEN it.
        if (popupState == 0 && !anyDialogueOpen)
        {
            OpenPanel();
        }
    }

    private void OpenPanel()
    {
        toDisplay.SetActive(true);
        popupState = 1; // Move to "Open" state so Update() stops calling this
    }

    // IMPORTANT: Link your Button's "On Click()" to THIS function
    public void ClosePanel()
    {
        toDisplay.SetActive(false);
        popupState = 2; // Move to "Finished" state so it never opens again
        Debug.Log("Popup closed and state set to 2.");
    }
}