using NutriQuest.Interfaces;
using NutriQuest.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace NutriQuest.Collectibles
{
    public class UnhealthyFood : Food
    {

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("OnCollisionEnter");
            if (collision.gameObject.CompareTag("Player"))
            {
                ILooseEnergy looseEnergy = collision.gameObject.GetComponentInChildren<ILooseEnergy>();
                if (looseEnergy != null )
                {
                    looseEnergy.LooseEnergy(value);
                }
                Destroy(gameObject);
            }
        }
    }
}
