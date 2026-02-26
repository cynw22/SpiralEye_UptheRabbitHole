using UnityEngine;

public class SwitchParticles : MonoBehaviour
{
    public ParticleSystem particleSys;

    [SerializeField] public SwitchManager switchManager;
    [SerializeField] public bool isConstanceParticles;

    private void Start()
    {
        particleSys = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isConstanceParticles == switchManager.sisterPOV)
        {
            particleSys.emissionRate = 2;
        }
        else
        {
            particleSys.emissionRate = 0;
        }
    }
}
