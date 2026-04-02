using UnityEngine;

public class ExplanationPopup2 : MonoBehaviour
{
    [SerializeField] public GameObject toDisplay;
    // States: 0 = Waiting for dialogue, 1 = Popup is Open, 2 = Finished Forever
    private int popupState = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        toDisplay.SetActive(true);
        popupState = 0;
    }


    // Update is called once per frame
    void Update()
    {
        // If we have already closed the popup (State 2), stop running logic entirely.
        if (popupState == 2) return;

        // LOGIC: If we are waiting (State 0) AND no dialogues are open, OPEN it.
        if (popupState == 0)
        {
            OpenPanel();
        }
    }

    public void OpenPanel()
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
