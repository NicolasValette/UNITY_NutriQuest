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
    private float _speed = 5f;
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private Animator _animator;

    private Vector2 _moveDirection = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        float speed = -_moveDirection.x * _speed;
        Vector3 vel = new Vector3(speed, 0f, 0f);
        Debug.Log($"Speed : {vel}");
        _rb.velocity= vel;
        _animator.SetFloat("Speed", speed * speed);
    }


    public void Move(Vector2 moveDirection)
    {
        Debug.Log($"I Move oward {moveDirection}" );
        _moveDirection= moveDirection;
    }

    public void Jump()
    {
        Debug.Log("I Jump");
    }

}
