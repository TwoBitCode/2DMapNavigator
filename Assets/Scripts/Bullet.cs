using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Speed at which the bullet moves (can be adjusted in the Inspector)
    [Range(1, 10)] // Limits the range of speed to values between 1 and 10
    [SerializeField] private float speed = 10f;

    // Lifetime of the bullet in seconds before it gets destroyed
    [Range(1, 10)] // Limits the range of lifetime to values between 1 and 10
    [SerializeField] private float lifeTime = 3f;

    private Rigidbody2D rb; // Reference to the Rigidbody2D component for physics interactions

    private void Start()
    {
        // Get the Rigidbody2D component attached to the bullet GameObject
        rb = GetComponent<Rigidbody2D>();

        // Automatically destroy the bullet after its lifetime expires
        Destroy(gameObject, lifeTime);
    }

    private void FixedUpdate()
    {
        // Move the bullet forward (in the direction it is facing)
        rb.linearVelocity = transform.up * speed;
    }
}
