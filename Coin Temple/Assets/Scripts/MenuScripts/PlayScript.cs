using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public GameObject TransitionUp;
    public GameObject TransitionDown;
    Animator animator;

    void Start()
    {
        TransitionUp.GetComponent<Animator>().GetBool("onSceneChanging");
        TransitionDown.GetComponent<Animator>().GetBool("onSceneChanging");
        TransitionUp.GetComponent<Animator>().SetBool("onSceneChanging", false);
        TransitionDown.GetComponent<Animator>().SetBool("onSceneChanging", false);
    }

    public void Play()
    {
        TransitionUp.GetComponent<Animator>().SetBool("onSceneChanging", true);
        TransitionDown.GetComponent<Animator>().SetBool("onSceneChanging", true);
    }


}
