using UnityEngine;
using UnityEngine.UI;

public class timesWrong : MonoBehaviour
{
    [SerializeField] TeaMakingControl TeaControl;
    [SerializeField] public GameObject Image1;
    [SerializeField] public GameObject Image2;
    [SerializeField] public GameObject Image3;
    //public Image image;
    //public float newAlpha;

    int amountCollected;
    int totalAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image1.SetActive(true);
        Image2.SetActive(true);
        Image3.SetActive(true);
        if (TeaControl != null)
        {
            amountCollected = 0;
            totalAmount = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TeaControl != null)
            amountCollected = TeaControl.timesWrong;
        if (amountCollected == 1) {
            ChangeAlpha(Image1);
        }
        else if (amountCollected == 2)
        {
            ChangeAlpha(Image2);
        }
        else if(amountCollected == 3)
        {
            ChangeAlpha(Image3);
        }
    }

    public void ChangeAlpha(GameObject ImageSprite) {
        //Color newColor = ImageSprite.color;
        //newColor.a = newAlpha;
        //ImageSprite.color = newColor;

        ImageSprite.SetActive(false);

    }
}
