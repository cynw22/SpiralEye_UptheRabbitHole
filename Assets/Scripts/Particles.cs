using UnityEngine;

public class Particles : MonoBehaviour
{
    ParticleSystem rose1P;
    ParticleSystem rose2P;
    ParticleSystem rose3P;
    ParticleSystem rose4P;
    ParticleSystem rose5P;
    ParticleSystem rose6P;
    ParticleSystem rose7P;
    ParticleSystem rose8P;
    ParticleSystem rose9P;
    ParticleSystem rose10P;
    ParticleSystem rose11P;
    ParticleSystem rose12P;
    ParticleSystem rose13P;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rose1P = GameObject.Find("Rose1Particle").GetComponent<ParticleSystem>();
        rose2P = GameObject.Find("Rose2Particle").GetComponent<ParticleSystem>();
        rose3P = GameObject.Find("Rose3Particle").GetComponent<ParticleSystem>();
        rose4P = GameObject.Find("Rose4Particle").GetComponent<ParticleSystem>();
        rose5P = GameObject.Find("Rose5Particle").GetComponent<ParticleSystem>();
        rose6P = GameObject.Find("Rose6Particle").GetComponent<ParticleSystem>();
        rose7P = GameObject.Find("Rose7Particle").GetComponent<ParticleSystem>();
        rose8P = GameObject.Find("Rose8Particle").GetComponent<ParticleSystem>();
        rose9P = GameObject.Find("Rose9Particle").GetComponent<ParticleSystem>();
        rose10P = GameObject.Find("Rose10Particle").GetComponent<ParticleSystem>();
        rose11P = GameObject.Find("Rose11Particle").GetComponent<ParticleSystem>();
        rose12P = GameObject.Find("Rose12Particle").GetComponent<ParticleSystem>();
        rose13P = GameObject.Find("Rose13Particle").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        rose1P.Play();
        rose2P.Play();
        rose3P.Play();
        rose4P.Play();
        rose5P.Play();
        rose6P.Play();
        rose7P.Play();
        rose8P.Play();
        rose9P.Play();
        rose10P.Play();
        rose11P.Play();
        rose12P.Play();
        rose13P.Play();
    }

    void OnDisable()
    {
        rose1P.Stop();
        rose2P.Stop();
        rose3P.Stop();
        rose4P.Stop();
        rose5P.Stop();
        rose6P.Stop();
        rose7P.Stop();
        rose8P.Stop();
        rose9P.Stop();
        rose10P.Stop();
        rose11P.Stop();
        rose12P.Stop();
        rose13P.Stop();
    }
}
