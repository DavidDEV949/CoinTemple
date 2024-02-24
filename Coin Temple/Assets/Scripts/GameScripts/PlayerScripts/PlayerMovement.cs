using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    Rigidbody2D rb2d;
    public float SpeedX;
    public float SpeedY;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        SpeedX = 2500f;
        SpeedY = 18000f;
    }

    void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(new Vector2(0, SpeedY * Time.fixedDeltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(new Vector2(-SpeedX * Time.fixedDeltaTime, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(new Vector2(SpeedX * Time.fixedDeltaTime, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("groundCollision"))
        {
            
        }
    }

}
