using NutriQuest.Character.Effects;
using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffect : MonoBehaviour, IApplyEffect
{
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public void ApplyEffect(Effect effectToApply)
    {
        effectToApply.Apply();
    }
}
