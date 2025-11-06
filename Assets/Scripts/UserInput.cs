using UnityEngine;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;

    public InputSystem_Actions controls;
    public float switchInput;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // This maintains one player character loaded in at all times
        }
        else
        {
            Destroy(gameObject); // Destroy occurs if a duplicate player character is created
        }

        controls = new InputSystem_Actions();
        controls.Player.Switch.started += context => switchInput = context.ReadValue<float>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
