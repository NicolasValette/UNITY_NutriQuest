using NutriQuest.Interfaces;
using UnityEngine;

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
