using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Vector2 movement;
    public float speed;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirction = player.position - transform.position;
        float angel = Mathf.Atan2(dirction.y, dirction.x) * Mathf.Rad2Deg;
        rb.rotation = angel;
        dirction.Normalize();
        movement = dirction;
        

    }
    private void FixedUpdate()
    {
        moveCharchter(movement); 
    }
    void moveCharchter(Vector2 dirction) { rb.MovePosition((Vector2)transform.position + (dirction * speed * Time.deltaTime)); }
}
