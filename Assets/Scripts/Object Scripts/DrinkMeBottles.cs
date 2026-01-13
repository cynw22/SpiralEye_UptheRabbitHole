using UnityEngine;

public class DrinkMeBottles : MonoBehaviour
{
    public bool isSafe = false;
    [SerializeField] Bookshelf bookshelf;

    private void OnMouseDown()
    {
        if (isSafe)
        {
            bookshelf.numFoundBottles++;
            gameObject.SetActive(false);
        }
    }
}
