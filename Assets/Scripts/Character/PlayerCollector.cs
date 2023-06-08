using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
   
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.CompareTag("Collectible"))
        {
            ICollectible collect = other.gameObject.GetComponent<ICollectible>();
            if (collect != null)
            {
                collect.OnCollect(gameObject);
            }
            
        }
    }
}
