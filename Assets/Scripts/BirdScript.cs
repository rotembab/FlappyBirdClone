using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
   private InputSystem_Actions _playerInput;
    public float jumpForce;

    void birdJump()
    {
        rb.linearVelocity = (Vector2.up * jumpForce);
    }
    private void Start()
    {
        _playerInput = new InputSystem_Actions();
        _playerInput.Enable();
        birdJump();

    }

    private void OnJump()
    {
        birdJump();
    }

}
