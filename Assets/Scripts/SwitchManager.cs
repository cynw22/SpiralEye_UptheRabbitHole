using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchManager : MonoBehaviour
{
    // POV switching
    public static bool ALICE = false;
    public static bool CONSTANCE = true;
    public bool allowSwitching;
    [SerializeField] public bool sisterPOV;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sisterPOV = CONSTANCE;
        allowSwitching = true;
    }

    // Update is called once per frame
    void Update()
    {
        // get pov switch input
        var switchControl = UserInput.instance.controls.Player.Switch;

        if (switchControl.WasPressedThisFrame())
        {
            switchPOV();
        }
    }

    public void switchPOV()
    {
        if (allowSwitching)
        {
            sisterPOV = !sisterPOV;
            Debug.Log("Perspective switched to " + sisterPOV);
        }
    }

    public void switchPOV(bool POV)
    {
        if (sisterPOV != POV && allowSwitching)
        {
            sisterPOV = POV;
        }
    }
}