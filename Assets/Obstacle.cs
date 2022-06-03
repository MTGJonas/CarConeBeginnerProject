using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int frameRate;
    [SerializeField] private float _speed;
    [SerializeField] private float _minPos = -2f;
    [SerializeField] private float _maxPos= 2f;
    

    void Update()
    {
        Application.targetFrameRate = frameRate;
        MoveLeft();
        TryResetPosition();
    }

        private void MoveLeft()
        {
            transform.position += Vector3.left * SpeedManager.Speed * Time.unscaledDeltaTime;
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
