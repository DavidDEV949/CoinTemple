using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public GameObject TransitionUp;
    public GameObject TransitionDown;

    public void Play()
    {

        //TransitionUp.transform.Translate(0, -350 * Time.deltaTime, 0);
        //TransitionDown.transform.Translate(0, 350 * Time.deltaTime, 0);

        TransitionUp.GetComponent<Rigidbody2D>().gravityScale = 0;
        TransitionDown.GetComponent<Rigidbody2D>().gravityScale = 0;

        TransitionUp.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);
        TransitionDown.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);

        //SceneManager.LoadScene("GameScene");

    }


}
