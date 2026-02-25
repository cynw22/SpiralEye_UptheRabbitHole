using UnityEngine;

public class PopupBackground : MonoBehaviour
{
    public GameObject background;

    private void Start()
    {
        background.SetActive(false);
    }
    public void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            background.SetActive(false);
        }
    }
}
