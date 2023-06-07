using NutriQuest.Interfaces;
using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;


namespace NutriQuest.Player
{
    public class PlayerEnergy : MonoBehaviour, IAddEnergy, ILooseEnergy, Interfaces.IObservable<int>
    {
        [SerializeField]
        private int _energy = 100;
        public int Energy { 
            get => _energy;
            private set
            {
                _energy = value;
                OnValueChange?.Invoke(_energy);
            }
        }

        //public event Action<int> OnEnergyChange;
        public event Action<int> OnValueChange;

        //public event Action<int> OnEnergyUpdate { add { OnEnergyChange += value; } remove { } }

        public void LooseEnergy(int value)
        {
            Debug.Log($"Player energy ({Energy}) loose {value} energy : ");
            Energy -= value;
        }
        public void AddEnergy(int value)
        {
            Debug.Log($"Player energy ({Energy}) add {value} energy : ");
            Energy += value;
        }
    }
}
