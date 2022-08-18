using UnityEngine;

public class HurtOnTouch : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        Player player = other.collider.GetComponent<Player>();
        if (player != null)
        {
            player.TryTakeDamage();
        }
    }

}
