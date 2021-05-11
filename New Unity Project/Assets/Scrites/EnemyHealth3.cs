using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth3 : MonoBehaviour
{
    public int max = 100;
    public int current;
    public GameObject Damagepopup;
    private UnityEngine.Object explosionRef;
    private UnityEngine.Object alien;

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        alien = Resources.Load("Alien (3)");

        current = max;
        explosionRef = Resources.Load("EnemyExplosion");
    }

    // Update is called once per frame
    void Update()
    {


        if (current <= 0)
        {
            Score.value += 1;
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector2(transform.position.x, transform.position.y + .3f);
            Score.value += 1;
            gameObject.SetActive(false);
            Invoke("Respon", 5);
        }
    }

    /* void ShowFloatingText()
     {
         Damagepopup = Instantiate(Damagepopup, transform.position, Quaternion.identity);
         Damagepopup.GetComponent<TextMesh>().text = current.ToString() ;
     }
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("playerBulett"))
        {
            TakeDamage(20);
            /*if (Damagepopup)
            {
                ShowFloatingText();
            }*/
        }

    }
    void TakeDamage(int damage)
    {
        current -= damage;

    }
    void Respon()
    {

        GameObject enemy = (GameObject)Instantiate(alien);
        enemy.transform.position = transform.position;


        Destroy(gameObject);
    }
}
