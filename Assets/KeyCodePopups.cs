using UnityEngine;

public class KeyCodePopups : MonoBehaviour
{
    [Header("References")]
    public PuzzleControl1 puzzleManager; // The script that has the booleans
    public GameObject missingCookiePopup; // The UI Panel to turn on
    public GameObject missingBottlePopup; // The UI Panel to turn on
    public GameObject missingBothPopup; // The UI Panel to turn on

    // This prevents the popup from flicking back on after you close it
    private bool hasBeenClosed = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            // 1. If the player already clicked 'Close', stop doing anything.
            if (hasBeenClosed) return;

        // 2. Check the conditions
        // This triggers if chest is false AND if bottles is false
        if (!puzzleManager.chestIsOpen && puzzleManager.allBottlesFound)
        {
            ShowCookiePopup();
        }
        if (puzzleManager.chestIsOpen && !puzzleManager.allBottlesFound)
        {
            ShowBottlePopup();
        }

        if (!puzzleManager.chestIsOpen && !puzzleManager.allBottlesFound)
        {
            ShowBothPopup();
        }
        }
    }

    void ShowBothPopup()
    {
        missingBothPopup.SetActive(true);
    }

    void ShowCookiePopup()
    {
        missingCookiePopup.SetActive(true);
    }
    void ShowBottlePopup()
    {
        missingBottlePopup.SetActive(true);
    }

    // IMPORTANT: Link your UI Button "On Click()" to this function
    public void ClosePopup()
    {
        missingBothPopup.SetActive(false);
        missingBottlePopup.SetActive(false);
        missingCookiePopup.SetActive(false);

        // This is the key: it tells Update() to stop forcing the popup open
        hasBeenClosed = true;
    }

}
