using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using System.Collections;

public class PopupManager : MonoBehaviour
{
    public static PopupManager Instance;

    [Header("UI Elements")]
    public GameObject popupPanel;
    public TextMeshProUGUI popupText; 

    [Header("Settings")]
    public float displayTime = 2f;

    private Coroutine currentCoroutine;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        popupPanel.SetActive(false);
    }

    public void ShowPopup(string message)
    {
        // Stop previous popup if active
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        popupText.text = message;
        popupPanel.SetActive(true);

        currentCoroutine = StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(displayTime);
        popupPanel.SetActive(false);
        currentCoroutine = null;
    }
}