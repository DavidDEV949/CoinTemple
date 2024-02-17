using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimiter : MonoBehaviour
{

    int FPSLimiterValue;

    void Start()
    {
        FPSLimiterValue = 60;
        Application.targetFrameRate = FPSLimiterValue;
    }

}
