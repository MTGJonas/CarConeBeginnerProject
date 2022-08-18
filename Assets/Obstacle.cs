using System.IO;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _obstacleSpeed = 1;
    [SerializeField] private float _minPos = -2f;
    [SerializeField] private float _maxPos= 2f;
    

    void Update()
    {
        MoveLeft();
        TryResetPosition();
    }

        private void MoveLeft()
        {
            transform.position += Vector3.left * SpeedManager.GameSpeed * _obstacleSpeed * Time.unscaledDeltaTime;
        }

        private void TryResetPosition()
        {
            if (transform.position.x < -15)
            {
                transform.position = new Vector3(15, GetRandomPosition(), 0);
            }
        }

        private float GetRandomPosition()
        {
            
            float randomNumber = Random.Range(_minPos, _maxPos);
            return randomNumber;
        }
}
