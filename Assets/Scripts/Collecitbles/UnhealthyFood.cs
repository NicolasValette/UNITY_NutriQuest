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
        public override void OnCollect(GameObject player)
        {
            ILooseEnergy looseEnergy = player.GetComponentInChildren<ILooseEnergy>();
            if (looseEnergy != null)
            {
                looseEnergy.LooseEnergy(value);
            }
            Destroy(gameObject);
        }
    }
}
