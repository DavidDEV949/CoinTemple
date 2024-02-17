using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Transform tr;
    Rigidbody2D rb2d;
    public float SpeedX;
    public float SpeedY;

    void Start()
    {
        tr = GetComponent<Transform>();
        rb2d = GetComponent<Rigidbody2D>();
        SpeedX = 10f;
        SpeedY = 12000f;
    }

    void Update()
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
            tr.Translate(-SpeedX * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tr.Translate(SpeedX * Time.deltaTime, 0, 0);
        }
    }

}
