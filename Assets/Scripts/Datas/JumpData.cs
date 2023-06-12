using UnityEngine;

[CreateAssetMenu(menuName = "Data/New Jump Data")]
public class JumpData : ScriptableObject
{
    [Range(0f, 10f)]
    [SerializeField]
    private float _jumpForce = 5f;
    [Range(0f, 1f)]
    [SerializeField]
    private float _gravityScale = 0.15f;               //Change gravitiy of player to make him less floaty;
    [Range(0f, 1f)]
    [SerializeField]
    private float _fallingGravityScale = 0.7f;
    [SerializeField]
    private float _jumpButtonTime = 0.25f;


    public float JumpForce => _jumpForce;
    public float GravityScale => _gravityScale;
    public float FallingGravityScale => _fallingGravityScale;
    public float JumpButtonTime => _jumpButtonTime;
}
