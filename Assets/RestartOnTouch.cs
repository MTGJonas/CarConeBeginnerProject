using UnityEngine;

public class RestartOnTouch : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.GetComponent<Player>() != null)
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
