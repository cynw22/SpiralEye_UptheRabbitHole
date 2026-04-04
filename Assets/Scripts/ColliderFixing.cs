using Unity.VisualScripting;
using UnityEngine;

public class ColliderFixing : MonoBehaviour
{
    public GameObject ActiveCollider;
    public GameObject HidingCollider;

    // Update is called once per frame
    void Update()
    {
        if (ActiveCollider.activeInHierarchy == true)
        {
            HidingCollider.GetComponent<BoxCollider2D>().enabled = false;
        }

        else if (ActiveCollider.activeInHierarchy == false)
        {
            HidingCollider.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
