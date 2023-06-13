using NutriQuest.Datas;
using NutriQuest.Interfaces;
using UnityEngine;

namespace NutriQuest.Character
{
    [RequireComponent(typeof(GroundCheck))]
    public class PlayerMovement : MonoBehaviour, IMove, IJump, IKnockback
    {
        [SerializeField]
        private PlayerData _playerData;
        [SerializeField]
        private JumpData _jumpData;

        //[SerializeField]
        //private float _speed = 5f;
        //[SerializeField]
        //private float _acceleration = 0.05f;
        //[SerializeField]
        //private float _jumpForce = 50f;
        [SerializeField]
        private Rigidbody _rb;
        [SerializeField]
        private PlayerAnimation _playerAnimation;

        private Vector2 _moveDirection = Vector2.zero;
        private int _direction = 1;                    //Direction of the movement, 1= to the right, -1 = to the felt;
        private Vector3 currentVelocity = Vector3.zero;

        private GroundCheck _groundCheck;
        private bool _isStartJumping;
        private float _jumpingTime = 0f;
        private bool _isJumping;
        private bool _isJumpActive;
        private float _fallingMultiplier = 1f;
        public bool IsStartJumping => _isStartJumping;

        // Start is called before the first frame update
        void Start()
        {
            _groundCheck = GetComponent<GroundCheck>();
        }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
            JumpPlayer();
        }
        private void MovePlayer()
        {
            float speed = -_moveDirection.x * _playerData.Speed;
            Vector3 movement = new Vector3(speed, _rb.velocity.y, 0f);

            //_rb.velocity = movement;
            _rb.velocity = Vector3.SmoothDamp(_rb.velocity, movement, ref currentVelocity, _playerData.Acceleration);
            _playerAnimation.Move(speed * speed);
        }

        private void JumpPlayer()
        {
            if (_isJumping)
            {
                _rb.velocity = new Vector3(_rb.velocity.x, _jumpData.JumpForce, _rb.velocity.z);
                _jumpingTime += Time.deltaTime;
            }

            if (_rb.velocity.y >= 0)
            {
                _rb.AddForce((_jumpData.GravityScale) * _rb.mass * _fallingMultiplier * Physics.gravity);
            }
            else if (_rb.velocity.y < 0)
            {
                _rb.AddForce((_jumpData.FallingGravityScale) * _rb.mass * _fallingMultiplier * Physics.gravity);
            }

            if (_jumpingTime > _playerData.JumpButtonTime)
            {
                _isJumping = false;
            }

        }

        private void Flip()
        {

        }
        public void Move(Vector2 moveDirection)
        {
            Debug.Log($"I Move oward {moveDirection}");
            _moveDirection = moveDirection;
        }

        /// <summary>
        /// This method is called twice, when we pressed the jump button, and when we release it
        /// </summary>
        public void Jump()
        {

            Debug.Log("I Jump");

            //if (_rb.velocity.y == 0f)
            //{

            if (!_isJumpActive && _groundCheck.IsGrounded())
            {
                _isJumping = true;
                _isJumpActive = true;
                _jumpingTime = 0f;
            }
            else
            {
                _isJumping = false; ;
                _isJumpActive = false;
            }

            //}





            Debug.Log($"Jump ");
            //_rb.AddForce(Vector3.up * _playerData.JumpForce, ForceMode.Impulse);
            //_rb.velocity = new Vector3(_rb.velocity.x, _playerData.JumpForce, _rb.velocity.z);
            _playerAnimation.Jump();
        }


        public void Knockback(float knockBackForce)
        {
            Debug.Log("knockback");
            _rb.AddForce(-_rb.velocity.normalized * knockBackForce, ForceMode.Impulse);
        }

        public void FallFaster()
        {
            _fallingMultiplier = (_fallingMultiplier % 2) + 1f;
            Debug.Log($"Falling mult = {_fallingMultiplier}");
        }
    }
}