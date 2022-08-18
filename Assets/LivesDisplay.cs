using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    private Player _player;
    private TMP_Text _livesDisplay;
    private void Awake()
    {
        _player = FindObjectOfType<Player>();
        _livesDisplay = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _player.LivesChanged += UpdateLivesText;
    }

    private void OnDisable()
    {
        _player.LivesChanged -= UpdateLivesText;
    }

    private void UpdateLivesText()
    {
        _livesDisplay.SetText(_player.Lives.ToString());
    }
}
