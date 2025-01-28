using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public InputActionReference jumpAction;
    public float jumpForce; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.action.IsPressed())
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
