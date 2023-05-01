using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private BoxCollider2D _collider2D;
    private Animator _animator;
    private float _dirX = 0;

    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float jumpHeight = 20f;
    [SerializeField] private LayerMask jumpableGround;
    
    private enum MovementState
    {
        Idle, Running, Jumping, Falling
    }

    private SpriteRenderer _spriteRenderer;
    private static readonly int State = Animator.StringToHash("state");

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<BoxCollider2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _dirX = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.velocity = new Vector2(_dirX * movementSpeed, _rigidbody2D.velocity.y);

        if ((Input.GetKeyDown("w") || Input.GetButtonDown("Jump")) && IsGrounded())
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpHeight);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        
        
        switch (_dirX)
        {
            case > 0f:
                state = MovementState.Running;
                _spriteRenderer.flipX = false;
                break;
            case < 0f:
                state = MovementState.Running;
                _spriteRenderer.flipX = true;
                break;
            default:
                state = MovementState.Idle;
                break;
        }

        switch (_rigidbody2D.velocity.y)
        {
            case > .1f:
                state = MovementState.Jumping;
                break;
            case < -.1f:
                state = MovementState.Falling;
                break;
        }

        _animator.SetInteger(State, (int)state);
    }

    private bool IsGrounded()
    {
        var bounds = _collider2D.bounds;
        return Physics2D.BoxCast(bounds.center, bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
