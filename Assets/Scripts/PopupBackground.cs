using UnityEngine;

public class PopupBackground : MonoBehaviour
{
    public GameObject background;
    public GameObject door;

    private void Start()
    {
        background.SetActive(false);
    }

    private void Update()
    {
        if (gameObject.activeSelf) { door.SetActive(false); }
    }

    public void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            background.SetActive(false);
            door.SetActive(true);
        }
    }
}
