using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColliderFixingPoly : MonoBehaviour
{
    public GameObject ActiveCollider;
    public GameObject HidingCollider;

    // Update is called once per frame
    void Update()
    {
        if (ActiveCollider.activeInHierarchy == true)
        {
            HidingCollider.GetComponent<PolygonCollider2D>().enabled = false;
        }

        else if (ActiveCollider.activeInHierarchy == false)
        {
            HidingCollider.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
