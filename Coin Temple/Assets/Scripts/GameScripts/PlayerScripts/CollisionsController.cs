using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("ladderCollision") && Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 10 * Time.deltaTime, 0);
        }
    }

}
