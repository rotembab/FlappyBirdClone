using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private InputSystem_Actions _playerInput;
    public float jumpForce;
    private LogicScript _logicScript;
    private bool _isAlive = true;
    
  
    void BirdJump()
    {
        if (_isAlive)
        {
            rb.linearVelocity = (Vector2.up * jumpForce);
        }
    }
    private void Start()
    {
        _logicScript = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
        _playerInput = new InputSystem_Actions();
        _playerInput.Enable();
        BirdJump();

    }

    private void OnJump()
    {
        BirdJump();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        
        if (other.gameObject.layer == 3)
        {
            _isAlive = false;
            _playerInput.Disable();
            _logicScript.GameOver();
        }
    }

}
