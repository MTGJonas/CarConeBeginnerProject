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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            _rigidbody2D.AddForce(Vector2.up*_force);
        }
    }

    

    
    
}
