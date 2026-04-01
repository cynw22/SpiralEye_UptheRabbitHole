using UnityEngine;
using UnityEngine.UI;

public class UserFeedbackManager : MonoBehaviour
{
    public PuzzleControl2 puzzleControl;
    public GameObject milkCollectedPopup;
    public Button closeButton;

    private bool hasShownPopup = false;


    //[SerializeField] GameObject popuptoClose;
    //public bool isPopupClosed;
    //PuzzleControl2 PuzzleControl;
    //bool puzzleMilk;
    //int clickCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        milkCollectedPopup.SetActive(false);
        closeButton.onClick.AddListener(ClosePopup);

        //isPopupClosed = false;
        //puzzleMilk = PuzzleControl.milk;   
        //clickCounter = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        //puzzleMilk = PuzzleControl.milk;
        //Debug.Log("PuzzleMilk =" + puzzleMilk);

        //if (puzzleMilk && !isPopupClosed)
        //{
        //    popuptoClose.SetActive(true);
        //    clickCounter++;
        //}
        //if (Input.GetMouseButtonDown(0) && clickCounter > 0) { 
        //    popuptoClose.SetActive(false);
        //    isPopupClosed = true;
        //}

        if (puzzleControl.milk && !hasShownPopup)
        {
            ShowPopup();
        }
    }

    void ShowPopup()
    {
        milkCollectedPopup.SetActive(true);
        hasShownPopup = true;
    }

    public void ClosePopup()
    {
        milkCollectedPopup.SetActive(false);
    }
}