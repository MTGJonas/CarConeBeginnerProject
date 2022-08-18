using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _force;
    [SerializeField] private float _playerScore;
    [SerializeField] private TMP_Text _tmpText;

    public Action LivesChanged;

    

    public int Lives { get; private set; }
    
    private void Start()
    {
        Time.timeScale = 0;
        Lives = 3;
        LivesChanged?.Invoke();
    }

    
    private void Update()
    {
        HandleMovement();
        UpdateScore();
    }

    private void HandleMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            _rigidbody2D.AddForce(Vector2.up * _force);
        }
    }

    private void UpdateScore()
    {
        _playerScore = Time.time * 2 * SpeedManager.GameSpeed;
        _tmpText.SetText(_playerScore.ToString("F0"));
    }

    public void TryTakeDamage()
    {
        if (Lives > 0)
        {
            Lives--;
            LivesChanged?.Invoke();
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
