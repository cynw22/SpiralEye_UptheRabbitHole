using UnityEngine;
using UnityEngine.UI;

// Referenced from https://www.youtube.com/watch?v=JybecYyj83k

public class CursorManager : MonoBehaviour
{
    public SwitchManager switchManager;
    private Vector3 hotspot = new Vector3(10.0f, 0.0f, 0.0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition + hotspot;
    }
}
