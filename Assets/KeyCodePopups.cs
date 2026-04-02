using UnityEngine;

public class MissingItemsController : MonoBehaviour
{
    [Header("References")]
    public PuzzleControl1 puzzleManager;

    [Header("UI Panels")]
    public GameObject cookieMissingPopup;
    public GameObject drinkMissingPopup;
    public GameObject bothMissingPopup;

    // We need 3 separate flags so each popup can be closed independently
    private bool cookiePopupDone = false;
    private bool drinkPopupDone = false;
    private bool bothPopupDone = false;

    void Update()
    {
        // --- COOKIE CHECK ---
        // If Cookie is NOT collected AND we haven't finished with this popup yet
        if (!puzzleManager.chestIsOpen && !cookiePopupDone && puzzleManager.allBottlesFound)
        {
            cookieMissingPopup.SetActive(true);
        }

        // --- BOTTLES CHECK ---
        if (!puzzleManager.allBottlesFound && !drinkPopupDone && puzzleManager.chestIsOpen)
        {
            drinkMissingPopup.SetActive(true);
        }

        // --- BOTH CHECK ---
        if (!puzzleManager.chestIsOpen && !bothPopupDone && !puzzleManager.allBottlesFound)
        {
            bothMissingPopup.SetActive(true);
        }
    }

    // --- CLOSE FUNCTIONS ---
    // Link each button to its specific function below

    public void CloseCookiePopup()
    {
        cookieMissingPopup.SetActive(false);
        cookiePopupDone = true; // Prevents it from reopening
    }

    public void CloseDrinkPopup()
    {
        drinkMissingPopup.SetActive(false);
        drinkPopupDone = true;
    }

    public void CloseBothPopup()
    {
        bothMissingPopup.SetActive(false);
        bothPopupDone = true;
    }
}