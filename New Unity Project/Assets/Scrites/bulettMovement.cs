using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulettMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    public GameObject hitEffect;
    private Transform player;
    private Vector2 target;

    public GameObject bullet;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
       
    }

    // Update is called once per frame
    void Update()
    {
       bullet.transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (bullet.transform.position.x == target.x && bullet.transform.position.y == target.y)
        {
         
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.1f);
            Destroy(gameObject);
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.collider.CompareTag("Player"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.1f);
            Destroy(gameObject);
        }
    }
   

}