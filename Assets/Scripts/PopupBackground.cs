using UnityEngine;

public class PopupBackground : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
