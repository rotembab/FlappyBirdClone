using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float destroyXPos = -45f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position +=  (Vector3.left * (moveSpeed * Time.deltaTime));
        if (transform.position.x <= destroyXPos)
        {
            Destroy(gameObject);
        }
    }
}
