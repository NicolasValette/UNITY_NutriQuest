using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NutriQuest.Character
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovement _playerMovement;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnMove()
        {
            Debug.Log("OnMove");
            _playerMovement.Move();
        }

        public void OnFire()
        {
            Debug.Log("OnFire");
            _playerMovement.Jump();
        }
    }
}
