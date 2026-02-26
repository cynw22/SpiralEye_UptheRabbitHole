using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

// youtube.com/shorts/Sxp07Qg3GoQ
public class DragDrop: MonoBehaviour
{
    public bool hovered;
    public Vector2 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;

    }

    private void OnMouseEnter()
    {
        hovered = true;
    }

    private void OnMouseExit()
    {
        hovered = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) & hovered) { 
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouseposition;

        }
        if (Input.GetMouseButtonUp(0)) {
            //handlerelease
            if (handleReleasePosition(transform.position))
            {
                //destroy object / implement other logic
            }
            else { 
                //return to original position
                transform.position = originalPosition;
            }

        }
    }

    public bool handleReleasePosition(Vector2 pos) {
        //change whn ther eis logic like overlapping?
        return false;
    
    }


}
