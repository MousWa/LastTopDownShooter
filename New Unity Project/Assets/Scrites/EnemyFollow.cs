using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Transform player;
    public Rigidbody2D rb;
    
 

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Soldier").transform;

        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
    }
}
