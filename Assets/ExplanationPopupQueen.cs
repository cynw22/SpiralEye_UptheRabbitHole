using UnityEngine;

public class ExplanationPopupQueen : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject toDisplay;
    [SerializeField] private GameObject DialogueOverall;

    static bool QueenInvite = true; // checks if QueenInvite is ture or false - true = open popup, false = close popup

    private int popupState = 0;
    private float startupDelay = 0.5f; // Wait half a second
    private float timer = 0f;

    void Start()
    {
        QueenInvite = true;
        // Start hidden to prevent the "flicker"
        toDisplay.SetActive(false);
        popupState = 0;
    }

    void Update()
    {
        if (popupState != 0) return;

        // 1. Wait for the startup delay to pass
        if (timer < startupDelay)
        {
            timer += Time.deltaTime;
            return;
        }

        if (QueenInvite) {
            OpenPanel();
        }
        if (!QueenInvite)
        {
            ClosePanel();
        }
    }

    public void OpenPanel()
    {
        toDisplay.SetActive(true);
        popupState = 1;
    }

    public void ClosePanel()
    {
        toDisplay.SetActive(false);
        popupState = 2;
        Debug.Log("Popup closed and state set to 2.");
    }
}