
using UnityEngine;

namespace NutriQuest.Datas
{
    [CreateAssetMenu(menuName = "Data/New Player")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        private int _energy;
        [SerializeField]
        private float _speed = 3f;
        [SerializeField]
        private float _acceleration = 0.15f;
       
        [SerializeField]
        private float _jumpButtonTime = 0.5f;

        public int Energy => _energy;
        public float Speed => _speed;
        public float Acceleration => _acceleration;
  
        public float JumpButtonTime => _jumpButtonTime;
    }
}
