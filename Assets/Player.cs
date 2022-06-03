using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _force;
    
    private void Start()
    {
        Time.timeScale = 0;
    }

    
    private void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            Debug.Log("hit space");
            _rigidbody2D.AddForce(Vector2.up*_force);
        }
    }

    

    
    
}
