using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour
{
    // asset that will be shown as the popup
    public GameObject popupObj;
    // public bool popupShown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        popupObj.SetActive(false);
        // popupShown = false;
    }

    private void OnMouseDown()
    {
        if (!popupObj.activeSelf)
        {
            popupObj.SetActive(true);
            Debug.Log("Popup up");
        }
        else
        {
            popupObj.SetActive(false);
            Debug.Log("Popup down");
        }
    }
}
