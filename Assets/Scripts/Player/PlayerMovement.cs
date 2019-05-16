using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float minJumpHeight = 1f, maxJumpHeight = 3.5f;
    public float acceleration = .25f;
    public float airSpeed = 6.4f, groundSpeed = 9.4f;
    public float gravity;
    public float gravityModifierFall;
    public float gravityModifierJump;
    public float maxJumpVelocity, minJumpVelocity;
    public float velocitySmoothing;
    public bool isLanded = true;

    public float timeToJumpApex = .65f;
    public float moveSpeed = 9;
    public float targetVelocity;

    private Vector2 _playerInput;
    private Vector3 _velocity;
    private float _accelerationAirborn;
    private float _targetVelocityX;
    private PlayerCollisions _playerCollisions;

    private void Awake()
    {
        _playerCollisions = GetComponent<PlayerCollisions>();
    }

    public void Update()
    {
        _playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        maxJumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravity) * minJumpHeight);
        gravity = -(2 * maxJumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        _velocity.y += gravity * Time.deltaTime;

        Move();
        if (Input.GetButtonUp("Jump"))                  //For variable jump
        {
            Jump();
        }
    }

    public void Move()
    {
        acceleration = (_playerInput.x == 1 || _playerInput.x == -1) ? acceleration : (acceleration / 5f);

        _targetVelocityX = _playerInput.x * moveSpeed;
        _velocity.x = Mathf.SmoothDamp(_velocity.x, _targetVelocityX, ref velocitySmoothing, acceleration);

        transform.Translate(_velocity);
    }

    public void Jump()
    {
        if (_velocity.y > minJumpVelocity)
        {
            _velocity.y = minJumpVelocity;
        }
    }
}
