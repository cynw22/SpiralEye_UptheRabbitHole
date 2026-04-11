using UnityEngine;

public class ControlsCode : MonoBehaviour
{
    [SerializeField] GameObject controlsPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //controlsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActive() { 
        controlsPanel.SetActive(true);
    }
    public void SetFalse()
    { controlsPanel.SetActive(false);}
}
