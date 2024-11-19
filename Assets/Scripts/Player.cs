using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed of the player's movement (adjustable in the Inspector)
    [SerializeField] private GameObject bulletPrefab; // Reference to the bullet prefab for shooting
    [SerializeField] private Transform firingPoint; // Transform from which bullets are spawned

    private Rigidbody2D rb; // Reference to the player's Rigidbody2D for movement
    private float mx; // Horizontal movement input
    private float my; // Vertical movement input
    private Vector2 mousePos; // Position of the mouse in world coordinates

    private void Start()
    {
        // Initialize the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get raw input for horizontal and vertical movement (e.g., arrow keys or WASD)
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");

        // Get the mouse position in world coordinates relative to the Main Camera
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the angle to rotate the player to face the mouse
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        transform.localRotation = Quaternion.Euler(0, 0, angle);

        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(); // Fire a bullet
        }
    }

    private void FixedUpdate()
    {
        // Set the player's velocity based on input, normalized to ensure consistent speed
        rb.linearVelocity = new Vector2(mx, my).normalized * speed;
    }

    private void Shoot()
    {
        // Instantiate (create) a new bullet at the firing point's position and rotation
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }
}
