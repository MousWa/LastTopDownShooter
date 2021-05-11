using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour
{
    public Transform firePoint;
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float movedistance;
    public float shootDistance;
    private float timeBetShoot;
    public float startShoot;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        timeBetShoot = startShoot;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        if (timeBetShoot <= 0)
        {
            if (Vector3.Distance(rb.position, player.position) < shootDistance)
            {
                Instantiate(Bullet, firePoint.position, firePoint.rotation);
                timeBetShoot = startShoot;
                FireSound.PlaySound("EFire");
            }
        }
        else
        {
            timeBetShoot -= Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        if (Vector3.Distance(rb.position, player.position) > movedistance)
        {
            rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        }
    }
}
