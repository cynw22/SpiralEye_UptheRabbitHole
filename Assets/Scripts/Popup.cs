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
            popupObj.SetActive(false);
            col.enabled = true;
        }
        else
        {
            col.enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (!popupObj.activeSelf && (switchManager.sisterPOV == isConstancePOV || switchManager.sisterPOV != isAlicePOV))
        {
            popupObj.SetActive(true);
            popupBg.SetActive(true);
            Debug.Log("Popup up");
        }
    }
}
