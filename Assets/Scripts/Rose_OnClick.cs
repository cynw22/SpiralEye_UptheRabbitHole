using UnityEngine;
using UnityEngine.SceneManagement;

public class Rose_OnClick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        Debug.Log("this works the scene just isn't in yet");
        SceneManager.LoadScene("GardenParty");
    }
}
