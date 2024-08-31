using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 100f;
    public float sideForce = 400f;

    private void FixedUpdate()
    {
        rb.AddForce(0,0,(forwardForce * Time.deltaTime)*0.8f);

        if (Input.GetKey("d")) {
            rb.AddForce( sideForce * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -0.01f) {
            FindAnyObjectByType<GameManager>().GameOver();
        }
    }
}
