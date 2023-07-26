using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreLightAngle = 70f;
    [SerializeField] float restoreLightIntensity = 20f;
    [SerializeField] float restoreLightRange = 80f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            FlashLightSystem fls = other.GetComponentInChildren<FlashLightSystem>();
            fls.RestoreLightAngle(restoreLightAngle);
            fls.RestoreLightIntensity(restoreLightIntensity);
            fls.RestoreLightRange(restoreLightRange);
            Destroy(gameObject);
        }
    }
}
