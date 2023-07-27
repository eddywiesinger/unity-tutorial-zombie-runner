using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        hitPoints = hitPoints - damage;
        ProcessHitEffect();
        if (hitPoints <= 0)
        {
            Debug.Log("You died.");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

    private void ProcessHitEffect()
    {
        FindObjectOfType<DisplayDamage>().Go();
    }
}
