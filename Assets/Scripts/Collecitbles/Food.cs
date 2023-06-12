using NutriQuest.Interfaces;
using UnityEngine;

namespace NutriQuest.Collectibles
{
    public abstract class Food : MonoBehaviour, ICollectible
    {
        [SerializeField]
        protected int value;

        public abstract void OnCollect(GameObject player);
    }
}
