using TMPro;
using UnityEngine;



public class counterDisplay : MonoBehaviour
{
    [SerializeField] PuzzleControl5 PuzzleControl5;
    [SerializeField] PuzzleControl4 PuzzleControl4;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleControl5 != null)
            amountCollected = PuzzleControl5.numRosesFound;
        if (PuzzleControl4 != null)
            amountCollected = PuzzleControl4.escapeRoomsComplete;
        counterText.text = amountCollected +"/"+ totalAmount.ToString();
    }
}
