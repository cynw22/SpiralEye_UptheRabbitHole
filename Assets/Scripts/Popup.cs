using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour
{
    // asset that will be shown as the popup
    public GameObject popupObj;
    public GameObject popupBg;

    private Collider2D col;

    public SwitchManager switchManager;
    [SerializeField] public bool isConstancePOV;
    [SerializeField] public bool isAlicePOV;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        popupObj.SetActive(false);
        col = gameObject.GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (!popupBg.activeSelf)
        {
            col.enabled = true;
        }
        else
        {
            col.enabled = false;
        }
        CheckBackground();
    }

    private void OnMouseDown()
    {
        ShowPopup();
    }

    public void ShowPopup()
    {
        GameObject[] popups;
        popups = GameObject.FindGameObjectsWithTag("Popup");
        for (int i = 0; i < popups.Length; i++)
        {
            popups[i].SetActive(false);
        }

        if (!popupObj.activeSelf && (switchManager.sisterPOV == isConstancePOV || switchManager.sisterPOV != isAlicePOV))
        {
            popupObj.SetActive(true);
            popupBg.SetActive(true);
            Debug.Log(gameObject.name + "Popup up");
        }
    }

    public void CheckBackground()
    {
        if (!popupBg.activeSelf)
        {
            popupObj.SetActive(false);
        }
    }    
}
