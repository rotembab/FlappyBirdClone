using System;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private LogicScript _logicScript;
    
    
    void Start()
    {
        _logicScript = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.layer == 6)
        { 
            _logicScript.AddScore(1);
        }
     
    }
}
