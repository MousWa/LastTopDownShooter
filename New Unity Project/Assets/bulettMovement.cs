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

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,target,speed*Time.deltaTime);
       


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
  
}
