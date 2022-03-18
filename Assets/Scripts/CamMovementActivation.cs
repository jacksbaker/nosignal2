using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovementActivation : MonoBehaviour
{

    public bool cam;

    public float stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch -= Time.deltaTime;

        if(stopwatch <= 0)
        {
            cam = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            cam = true;
            stopwatch = 1f;
        }

       
    }
}
