using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
   
    public void Exit()
    {
        Application.Quit();
        Debug.Log("On Application Quit");
    }

}
