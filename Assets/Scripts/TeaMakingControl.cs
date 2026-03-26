using UnityEngine;

public class TeaMakingControl : MonoBehaviour
{
    [SerializeField] public SwitchManager switchManager;

    [SerializeField] public GameObject conEnv;
    [SerializeField] public GameObject aliceEnv;

    // ALICE ENV OBJECTS


    //  CONSTANCE ENV OBJECTS



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setEnvironment();
    }

    void setEnvironment()
    {
        if (switchManager.sisterPOV)
        {
            conEnv.SetActive(true);
            aliceEnv.SetActive(false);
        }
        else
        {
            conEnv.SetActive(false);
            aliceEnv.SetActive(true);
        }
    }
}
