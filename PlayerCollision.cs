using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") {

            movement.enabled = false;
            FindAnyObjectByType<GameManager>().GameOver();
            Time.timeScale = 0f;
        }
    }
}
