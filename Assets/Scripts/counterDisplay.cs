using TMPro;
using UnityEngine;



public class counterDisplay : MonoBehaviour
{
    [SerializeField] PuzzleControl5 PuzzleControl5;
    [SerializeField] PuzzleControl4 PuzzleControl4;
    [SerializeField] TeaMakingControl TeaControl;
    public TextMeshProUGUI counterText;
    int amountCollected;
    int totalAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PuzzleControl5 != null) { 
            amountCollected = PuzzleControl5.numRosesFound;
            totalAmount = PuzzleControl5.numRoses;
        }
        if (PuzzleControl4 != null)
        {
            amountCollected = PuzzleControl4.escapeRoomsComplete;
            totalAmount = PuzzleControl4.totalEscapeRooms;
        }
        if (TeaControl != null)
        {
            amountCollected = TeaControl.desiredTea;
            totalAmount = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleControl5 != null)
            amountCollected = PuzzleControl5.numRosesFound;
        if (PuzzleControl4 != null)
            amountCollected = PuzzleControl4.escapeRoomsComplete;
        if (TeaControl != null)
            amountCollected = TeaControl.desiredTea;
        counterText.text = amountCollected +"/"+ totalAmount.ToString();
    }
}
