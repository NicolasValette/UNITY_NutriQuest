using NutriQuest.Datas;
using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour, IMove, IJump
{
    [SerializeField]
    private PlayerData _playerData;

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
    [SerializeField]
    private float _gravityScale = 0.15f;               //Change gravitiy of player to make him less floaty;
    [SerializeField]
    private float _fallingGravityScale = 0.7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
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
        if (_rb.velocity.y >= 0)
        {
            _rb.AddForce((_gravityScale) * _rb.mass * Physics.gravity);
        }
        else if (_rb.velocity.y < 0)
        {
            _rb.AddForce((_fallingGravityScale) * _rb.mass * Physics.gravity);
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

    public void Jump()
    {
        Debug.Log("I Jump");
        if (_rb.velocity.y == 0f)
        {
            Debug.Log($"Jump {_playerData.JumpForce}");
            _rb.AddForce(Vector3.up * _playerData.JumpForce, ForceMode.Impulse);
            _playerAnimation.Jump();
        }

    }

}
