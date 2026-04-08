using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColliderFixingButton : MonoBehaviour
{
    public GameObject ActiveCollider;
    public GameObject HidingCollider;

    // Update is called once per frame
    void Update()
    {
        if (ActiveCollider.activeInHierarchy == true)
        {
            HidingCollider.GetComponent<Button>().enabled = false;
        }

        else if (ActiveCollider.activeInHierarchy == false)
        {
            HidingCollider.GetComponent<Button>().enabled = true;
        }
    }
}
