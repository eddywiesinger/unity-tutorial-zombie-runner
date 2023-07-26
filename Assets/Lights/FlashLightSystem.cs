using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = .1f;
    [SerializeField] float rangeDecay = 1f;
    [SerializeField] float minimumAngle = 40f;
    [SerializeField] float minimumRange = 10f;

    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
        DecreaseLightRange();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
        myLight.innerSpotAngle = restoreAngle - 20;
    }

    public void RestoreLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }

    public void RestoreLightRange(float restoreRange)
    {
        myLight.range = restoreRange;
    }

    void DecreaseLightAngle()
    {
        if (myLight.spotAngle > minimumAngle)
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
            myLight.innerSpotAngle -= angleDecay * Time.deltaTime;
        }
    }

    void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }

    void DecreaseLightRange()
    {
        if (myLight.range > minimumRange)
        {
            myLight.range -= rangeDecay * Time.deltaTime;
        }
    }
}
