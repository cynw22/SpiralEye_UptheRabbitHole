using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public PuzzleControl1 puzzleControl;
    public SwitchManager switchManager;
    public Animator animator;
    bool open = false;
    [SerializeField] public GameObject popup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        popup.SetActive(false);
    }

    private void Update()
    {
        switch (open)
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
        open = puzzleControl.keyFound ? true : false;
        if (open == false) {
            popup.SetActive(true);
        }
    }
}
