using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int max = 100;
    public int current;
    public GameObject Damagepopup;
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
        if (current <= 0  ) {
            Destroy(gameObject);
        }
    }

    void ShowFloatingText()
    {
        Damagepopup = Instantiate(Damagepopup, transform.position, Quaternion.identity);
        Damagepopup.GetComponent<TextMesh>().text = current.ToString() ;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("kjasdbjkasbdas");
        if (collision.collider.CompareTag("playerBulett"))
        {
            TakeDamage(20);
            if (Damagepopup)
            {
                ShowFloatingText();
            }
        }
    }
    void TakeDamage(int damage)
    {
        current -= damage;
       
    }
}
