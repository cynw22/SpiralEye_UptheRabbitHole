using UnityEngine;
using UnityEngine.SceneManagement;

public class Rose_OnClick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void onClick()
    {
        SceneManager.LoadScene("GardenParty");
    }
}
