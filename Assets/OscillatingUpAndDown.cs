using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class OscillatingUpAndDown : MonoBehaviour
{
    [SerializeField] private float _oscillationFactor = 1;

    [SerializeField,Range(0,5)] private float _oscillationSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        var yPos = (Mathf.PerlinNoise(0,
                       Time.unscaledTime * _oscillationSpeed * SpeedManager.GameSpeed) - 0.5f) *
                   _oscillationFactor;
        //transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.time),0);
        transform.position = new Vector3(transform.position.x,yPos,0);
    }
}
