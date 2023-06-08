using NutriQuest.Interfaces;
using NutriQuest.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace NutriQuest.Collectibles
{
    public class HealthyFood : Food
    {
        public override void OnCollect(GameObject player)
        {
            IAddEnergy addEnergy = player.GetComponentInChildren<IAddEnergy>();
            if (addEnergy != null)
            {
                addEnergy.AddEnergy(value);
            }
            Destroy(gameObject);
        }

        //private void OnCollisionEnter(Collision collision)
        //{
        //    Debug.Log("OnCollisionEnter");
        //    if (collision.gameObject.CompareTag("Player"))
        //    {
        //        IAddEnergy addEnergy = collision.gameObject.GetComponentInChildren<IAddEnergy>();
        //        if (addEnergy != null)
        //        {
        //            addEnergy.AddEnergy(value);
        //        }
        //        Destroy(gameObject);
        //    }
        //}
    }
}