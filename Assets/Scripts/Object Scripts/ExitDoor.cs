using UnityEngine;
using System.Collections;
public class ExitDoor : MonoBehaviour 

{ 
    public PuzzleControl1 puzzleControl; 
    public SwitchManager switchManager; 
    
    public Animator animator; bool open = false;
    private bool dialogueTriggered = false;

    [SerializeField] public GameObject popup;
    [SerializeField] public GameObject popupBg; 
    
    public Collider2D col; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    { 
        animator = GetComponent<Animator>(); 
        popup.SetActive(false); 
        col = GetComponent<Collider2D>(); 
    } 
    private void Update() 
    { 
        switch (open) 
        { 
            case true: animator.Play(switchManager.sisterPOV == true ? "c_openDoor" : "a_openDoor"); 
                break; 
            case false: animator.Play(switchManager.sisterPOV == true ? "c_closedDoor" : "a_closedDoor"); 
                break; 
        } 

        //Disable collider if popup is active
        col.enabled = popupBg.activeSelf ? false : true; 
    } 
    private void OnMouseDown() 
    {
        // Only open the door if the key is found
        if (puzzleControl.keyFound)
        {
            open = true;

            // Trigger dialogue only once, after animation
            if (!dialogueTriggered)
            {
                dialogueTriggered = true;
                StartCoroutine(TriggerEndDialogue());
            }
        }
        else
        {
            // Show locked popup if puzzle not complete
            popup.SetActive(true);
        }
    }

    private IEnumerator TriggerEndDialogue()
    {
        // Wait for animation length
        float animLength = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        DialogueManager.Instance.TriggerDialogue("tutorial_puzzle_complete");
    }
}
