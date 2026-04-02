using UnityEngine;
using UnityEngine.UIElements;

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
        if (puzzleManager.chestIsOpen && puzzleManager.allBottlesFound)
        {
            CloseAllPopups();
            cookiePopupDone = true;
            drinkPopupDone = true;
            bothPopupDone = true;
        }
        // --- COOKIE CHECK ---
        // If Cookie is NOT collected AND we haven't finished with this popup yet
        if (!puzzleManager.chestIsOpen && !cookiePopupDone && puzzleManager.allBottlesFound)
        {
            CloseAllPopups();
            cookieMissingPopup.SetActive(true);
        }
        // --- BOTTLES CHECK ---
        else if (!puzzleManager.allBottlesFound && !drinkPopupDone && puzzleManager.chestIsOpen)
        {
            CloseAllPopups();
            drinkMissingPopup.SetActive(true);
        }
        // --- BOTH CHECK ---
        else if (!puzzleManager.chestIsOpen && !bothPopupDone && !puzzleManager.allBottlesFound)
        {
            CloseAllPopups();
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

    public void CloseAllPopups() {
        cookieMissingPopup.SetActive(false);
        drinkMissingPopup.SetActive(false);
        bothMissingPopup.SetActive(false);
    }
}