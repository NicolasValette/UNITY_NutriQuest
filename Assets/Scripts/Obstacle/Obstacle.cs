using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private int damageValue = 25;
    [SerializeField]
    private float knockbackForce = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Obstacle Collision");
        if (collision.gameObject.CompareTag("Player"))
        {
            ITakeDamage damage = collision.gameObject.GetComponentInChildren<ITakeDamage>();
            if (damage != null)
            {
                damage.TakeDamage(damageValue);
            }
            IKnockback kb = collision.gameObject.GetComponentInChildren<IKnockback>();
            if (kb != null)
            {
                kb.Knockback(knockbackForce);
            }

        }
    }
}
