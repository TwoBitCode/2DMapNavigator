using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;

    private Rigidbody2D rb;
    private float mx;
    private float my;
    private Vector2 mousePos;
    private bool isPortrait;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        transform.localRotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }


    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(mx, my).normalized * speed;
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }

}
