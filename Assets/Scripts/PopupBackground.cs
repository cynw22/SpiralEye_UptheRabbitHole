using UnityEngine;

public class PopupBackground : MonoBehaviour
{
    public GameObject background;
    public GameObject button;
    public bool isActive;
    
    private void Start()
    {
        background.SetActive(false);
        isActive = false;
    }

    public void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            background.SetActive(false);
            isActive = true;
        }
    }
}
