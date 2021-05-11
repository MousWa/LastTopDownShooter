using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int max = 100;
    public int current;
   
    // Start is called before the first frame update
    void Start()
    {
        current = max;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.N))
        {
            TakeDamage(20);
        }
    }
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("kjasdbjkasbdas");
        if (collision.collider.CompareTag("playerBulett"))
        {
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage)
    {
        current -= damage;
       
    }
}
