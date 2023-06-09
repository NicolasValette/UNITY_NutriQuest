using NutriQuest.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public static event Action OnWinLevel;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("win Flag");
        if (other.gameObject.CompareTag("Player"))
        {
            OnWinLevel?.Invoke();
        }
    }
  
}
