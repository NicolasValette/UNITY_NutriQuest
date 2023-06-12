using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    public void Move(float speed)
    {
        _animator.SetFloat("Speed", speed * speed);
    }
    public void Jump()
    {
        _animator.SetTrigger("Jump");
    }
}
