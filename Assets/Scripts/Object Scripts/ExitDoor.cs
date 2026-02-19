using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public PuzzleControl1 puzzleControl;
    public SwitchManager switchManager;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        switch (puzzleControl.keyFound)
        {
            case true:
                animator.Play(switchManager.sisterPOV == true ? "c_openDoor" : "a_openDoor");
                break;
            case false:
                animator.Play(switchManager.sisterPOV == true ? "c_closedDoor" : "a_closedDoor");
                break;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("level complete");
        // TO-DO: trigger the end of the level for real
    }
}
