using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem roseP;
    public PuzzleControl5 puzzle;

    // Update is called once per frame
    void OnEnable()
    {
        //roseP.Play();
    }

    void OnDisable()
    {
        roseP.Stop();
    }
}
