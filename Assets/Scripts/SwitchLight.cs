using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SwitchLight : MonoBehaviour
{
    [SerializeField] public SwitchManager switchManager;
    public Light2D light;

    [SerializeField] float intensity;
    [SerializeField] public bool isConstanceLight;

    public float interval;
    public float time;
    public float value;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light2D>();
        intensity = 1f;

        interval = 0.01f;
        time = 0;
        value = 0.08f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interval)
        {
            time = 0;

            if (isConstanceLight == switchManager.sisterPOV)
            {
                if (light.intensity < intensity)
                {
                    light.intensity += value;
                }
            }
            else
            {
                if (light.intensity > 0)
                {
                    light.intensity -= value;
                }
            }
        }
    }
}
