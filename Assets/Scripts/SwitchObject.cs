using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchObject : MonoBehaviour
{
    // POV switching
    static bool ALICE = false;
    static bool CONSTANCE = true;
    [SerializeField] public bool sisterPOV;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sisterPOV = CONSTANCE;
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
        sisterPOV = !sisterPOV;
    }

    public void switchPOV(bool POV)
    {
        if (sisterPOV != POV)
        {
            sisterPOV = POV;
        }
    }
}
