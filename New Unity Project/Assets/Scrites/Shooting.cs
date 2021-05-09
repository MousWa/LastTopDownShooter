using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPerfab;
    public float buzlletSpeed = 15f;
   
    public int maxHalth = 100;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();

        }
    }
    void Shoot() {
       GameObject bullet= Instantiate(bulletPerfab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * buzlletSpeed, ForceMode2D.Impulse);
    }
}
