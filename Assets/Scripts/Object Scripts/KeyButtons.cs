using UnityEngine;

public class KeyButtons : MonoBehaviour
{
    [SerializeField] private bool isDrinkMe;
    [SerializeField] public KeyBox keyBox;

    private void OnMouseDown()
    {
        keyBox.buttonPress(isDrinkMe);
    }
}
