using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoinMachine1Controller : MonoBehaviour
{

    private int CoinsGenerated = 0;
    public float incrementInterval = 1.0f;

    void Start()
    {
        InvokeRepeating("IncreaseValue", incrementInterval, incrementInterval);
    }

    void IncreaseValue()
    {
        CoinsGenerated++;
    }

    void Update()
    {
        Debug.Log("Current value: " + CoinsGenerated);
    }

}
