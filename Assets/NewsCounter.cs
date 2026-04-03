using TMPro;
using UnityEngine;

public class NewsCounter : MonoBehaviour
{ 
    [SerializeField] PuzzleControl4 PuzzleControl4;
    public TextMeshProUGUI counterText;
    int amountCollected;
    int totalAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PuzzleControl4 != null)
        {
            amountCollected = PuzzleControl4.numNewsFound;
            //totalAmount = PuzzleControl4.numNews;
            totalAmount = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleControl4 != null)
            amountCollected = PuzzleControl4.numNewsFound;
        counterText.text = amountCollected + "/" + totalAmount.ToString();
    }

}
