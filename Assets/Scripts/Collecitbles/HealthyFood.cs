using NutriQuest.Interfaces;
using UnityEngine;

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
    }
}