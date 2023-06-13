using NutriQuest.Interfaces;
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
            
            Vector2 inputValue = value.Get<Vector2>();
            Debug.Log("OnMove" + inputValue);
            _moveProvider.Move(inputValue);
            if (inputValue.y < 0)                       // if we press the down button
            {
                _jumpProvider.FallFaster();
                Debug.Log("Bas");
            }
        }

        public void OnFire()
        {
            Debug.Log("OnFire");
            
        }
        public void OnJump(InputValue value)
        {
            //if (value.isPressed)
            //{
            //    _startingJumpTime = Time.time;
            //}
            //else
            //{
            //    _jumpTime = Time.time - _startingJumpTime;
            //    Debug.Log($"Time of the Jump : {_jumpTime}");
            //}
            Debug.Log($"OnJump : {value.isPressed}");
            _jumpProvider.Jump();
        }
    }
}
