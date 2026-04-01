using TMPro;
using UnityEngine;



public class counterDisplay : MonoBehaviour
{
    [SerializeField] PuzzleControl5 PuzzleControl5;
    public TextMeshProUGUI counterText;
    int amountCollected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        amountCollected = PuzzleControl5.numRosesFound;
    }

    // Update is called once per frame
    void Update()
    {
        amountCollected = PuzzleControl5.numRosesFound;
        counterText.text = amountCollected +"/10" ;
    
}
}
