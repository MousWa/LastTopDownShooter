using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int max = 100;
    public int current;
    public HealthBar healthBar;
    public GameObject bullet;
    private UnityEngine.Object explosionRef;
    void Start()
    {
      
        current = max;
        healthBar.SetMaxHealth(max);
        explosionRef = Resources.Load("EnemyExplosion");
    }

    // Update is called once per frame
    private void Update()
    {
        if (current <= 0) {
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector2(transform.position.x, transform.position.y + .3f);
            Destroy(gameObject);
            
            SceneManager.LoadScene("Scenes/Menu");

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
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
