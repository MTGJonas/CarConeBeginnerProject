using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedManager : MonoBehaviour
{
    public static float GameSpeed { get; private set; }
    [SerializeField] private float _baseSpeed = 1f;
    [SerializeField] float speedMod = 1;


    private void Update()
    {
        float scaledSpeedMod = speedMod *0.001f;
        
        var updatedSpeedmod = Time.unscaledTime * scaledSpeedMod *scaledSpeedMod;

        
        _baseSpeed *= updatedSpeedmod + 1;
        GameSpeed = _baseSpeed;
    }
}
