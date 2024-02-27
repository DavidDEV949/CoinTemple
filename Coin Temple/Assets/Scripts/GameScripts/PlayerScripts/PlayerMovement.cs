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
        SpeedX = 6f;
        SpeedY = 7.5f;
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, SpeedY);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-SpeedX, rb2d.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(SpeedX, rb2d.velocity.y);
        }
    }

}
