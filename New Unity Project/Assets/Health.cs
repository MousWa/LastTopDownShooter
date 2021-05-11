using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int max = 100;
    public int current;
    public HealthBar healthBar;
    public GameObject bullet;
 
    void Start()
    {
      
        current = max;
        healthBar.SetMaxHealth(max);
  
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("kjasdbjkasbdas");
        if (collision.collider.CompareTag("Bullet"))
        {
            TakeDamage(10);
        }
    }


    void TakeDamage(int damage) {
        current -= damage;
        healthBar.SetHealth(current);
    }
}
