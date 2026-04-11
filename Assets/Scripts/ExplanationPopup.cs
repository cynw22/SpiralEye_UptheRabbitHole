using UnityEngine;

public class ExplanationPopup : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject toDisplay;
    [SerializeField] private GameObject DialogueOverall;

    [Header("Specific Dialogue Roots")]
    [SerializeField] private GameObject AliceDialouge;
    [SerializeField] private GameObject ConstanceDialouge;
    [SerializeField] private GameObject NarrativeDialouge;
    [SerializeField] private GameObject TutorialDialouge;
    [SerializeField] private GameObject ChoiceRoot;

    [Header("Sound")]
    public SoundFXManager soundFXManager;

    public AudioClip openSound;
    public AudioClip closeSound;
    [Range(0f, 1f)] public float volume = 1f;

    private int popupState = 0;
    private float startupDelay = 0.5f; // Wait half a second
    private float timer = 0f;

    void Start()
    {
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

        // 2. Once the timer is done, check if dialogue is active
        // If Dialogue is NOT active, then show the popup
        if (!IsDialogueActive())
        {
            OpenPanel();
        }
    }

    private bool IsDialogueActive()
    {
        // If the main container is off, treat dialogue as inactive
        if (DialogueOverall == null || !DialogueOverall.activeInHierarchy) return false;

        // Check if any specific dialogue window is active
        return AliceDialouge.activeInHierarchy ||
               ConstanceDialouge.activeInHierarchy ||
               NarrativeDialouge.activeInHierarchy ||
               TutorialDialouge.activeInHierarchy ||
               ChoiceRoot.activeInHierarchy;
    }

    public void OpenPanel()
    {
        toDisplay.SetActive(true);
        if (soundFXManager != null && openSound != null)
        {
            soundFXManager.PlaySound(openSound, volume);
        }
        popupState = 1;
    }

    public void ClosePanel()
    {
        toDisplay.SetActive(false);
        if (soundFXManager != null && closeSound != null)
        {
            soundFXManager.PlaySound(closeSound, volume);
        }
        popupState = 2;
        Debug.Log("Popup closed and state set to 2.");
    }
}