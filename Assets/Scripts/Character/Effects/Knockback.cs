using UnityEngine;

namespace NutriQuest.Character.Effects
{
    public class Knockback : Effect
    {
        private Rigidbody _rigidbody;
        private float _force;
        public Knockback(Rigidbody rb, float force)
        {
            _rigidbody = rb;
            _force = force;
        }

        public override void Apply()
        {
            Debug.Log("knockback");
            _rigidbody.AddForce(-_rigidbody.velocity.normalized * _force, ForceMode.Impulse);
        }
    }
}
