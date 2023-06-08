
using UnityEngine;

namespace NutriQuest.Datas
{
    [CreateAssetMenu(menuName = "Data/New Player")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        private int _energy;
        [SerializeField]
        private float _speed = 5f;
        [SerializeField]
        private float _acceleration = 0.05f;
        [SerializeField]
        private float _jumpForce = 50f;

        public int Energy => _energy;
        public float Speed => _speed;
        public float Acceleration => _acceleration;
        public float JumpForce => _jumpForce;
    }
}
