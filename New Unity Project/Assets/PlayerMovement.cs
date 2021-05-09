using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
      
    }
     void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 vector2 = mousePos - rb.position;
        Vector2 lookDir = vector2;
        float Angel = Mathf.Atan2(lookDir.y , lookDir.x)* Mathf.Rad2Deg-90f ;
        rb.rotation = Angel;
    }
}
