using TMPro;
using UnityEngine;

public class NewsCounter : MonoBehaviour
{
    [SerializeField] PuzzleControl2 PuzzleControl2;
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
        if (PuzzleControl2 != null) {
            amountCollected = 0;
            totalAmount = 5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleControl4 != null)
            amountCollected = PuzzleControl4.numNewsFound;

        if(PuzzleControl2 != null)
        {
            amountCollected = PuzzleControl2.numCollected;
        }

        counterText.text = amountCollected + "/" + totalAmount.ToString();
    }

}
