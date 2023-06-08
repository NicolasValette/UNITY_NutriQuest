using NutriQuest.Datas;
using NutriQuest.Interfaces;
using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;


namespace NutriQuest.Player
{
    public class PlayerEnergy : MonoBehaviour, IAddEnergy, ILooseEnergy, Interfaces.IObservable<int>
    {
        [SerializeField]
        private PlayerData _playerData;

        private int _currentEnergy;
        public int Energy { 
            get => _currentEnergy;
            private set
            {
                _currentEnergy = value;
                OnValueChange?.Invoke(_currentEnergy);
            }
        }

        public int Value => _currentEnergy;
        //public event Action<int> OnEnergyChange;
        public event Action<int> OnValueChange;

        //public event Action<int> OnEnergyUpdate { add { OnEnergyChange += value; } remove { } }

        private void Awake()
        {
            Energy = _playerData.Energy;
        }
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
