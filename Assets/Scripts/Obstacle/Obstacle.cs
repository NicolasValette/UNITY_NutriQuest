
using NutriQuest.Character.Effects;
using NutriQuest.Interfaces;
using UnityEngine;

namespace NutriQuest.Obstacles
{
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

                IApplyEffect effect = collision.gameObject.GetComponentInChildren<IApplyEffect>();
                if (effect != null)
                { 
                    Knockback kbEffect = new Knockback(collision.rigidbody, knockbackForce);
                    effect.ApplyEffect(kbEffect);
                    InvulnerabilityFrames invu = new InvulnerabilityFrames(5f, collision.gameObject, StartCoroutine);
                }
            }
        }
    }
}