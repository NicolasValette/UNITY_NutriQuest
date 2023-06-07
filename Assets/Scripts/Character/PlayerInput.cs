using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NutriQuest.Character
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private GameObject _player;

        private IMove _moveProvider;
        private IJump _jumpProvider;

        private void Awake()
        {
            _moveProvider= _player.GetComponentInChildren<IMove>();
            _jumpProvider= _player.GetComponentInChildren<IJump>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnMove(InputValue value)
        {
            Debug.Log("OnMove");
            _moveProvider.Move(value.Get<Vector2>());
        }

        public void OnFire()
        {
            Debug.Log("OnFire");
            
        }
        private void OnJump()
        {
            Debug.Log("OnJump");
            _jumpProvider.Jump();
        }
    }
}
