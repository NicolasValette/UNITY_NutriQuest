using NutriQuest.Character.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Timeline.Actions;
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
