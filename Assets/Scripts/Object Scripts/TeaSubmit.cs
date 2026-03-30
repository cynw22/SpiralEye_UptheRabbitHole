using UnityEngine;

public class TeaSubmit : MonoBehaviour
{
    [SerializeField] public Teapot teapot;

    private void OnMouseDown()
    {
        Debug.Log("submitting");
        teapot.SubmitTea();
    }
}
