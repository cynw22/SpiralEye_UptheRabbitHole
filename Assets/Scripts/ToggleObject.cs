using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Objects to Sync")]
    public GameObject pickupObject; // e.g., Your Pickup Item
    public GameObject envObject; // e.g., Your Environment or Popup

    void Update()
    {
        // Safety check to make sure the slots aren't empty
        if (pickupObject == null || envObject == null) return;

        // LOGIC: If Object A is active, Object B MUST be false.
        if (pickupObject.activeSelf)
        {
            if (envObject.activeSelf)
            {
                envObject.SetActive(false);
                Debug.Log("Object A is active, so Object B was forced to false.");
            }
        }
}
}
