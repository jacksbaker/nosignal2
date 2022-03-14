using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{

    public float stopwatch;

    public bool stopTime;

    // Start is called before the first frame update
    void Start()
    {
        stopTime = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            stopTime = true;
            
            stopwatch = 5;

        }


        if (stopwatch < 0)
        {
            stopTime = false;
        }
    }
}
