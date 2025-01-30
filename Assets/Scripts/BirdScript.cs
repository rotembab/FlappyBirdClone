using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
   private InputSystem_Actions _playerInput;
    public float jumpForce;

    private void Start()
    {
        _playerInput = new InputSystem_Actions();
        _playerInput.Enable();
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnJump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
