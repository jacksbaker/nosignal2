using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{

    static public bool fallingObjectIsTrue;
    private Rigidbody2D gravity;

    public float stopwatch;


    // Start is called before the first frame update
    void Start()
    {
        fallingObjectIsTrue = false;

        gravity = GetComponent<Rigidbody2D>();

        Telekinesis fallingObjectScript = gameObject.GetComponent<Telekinesis>();
    }

    // Update is called once per frame
    void Update()
    {

        stopwatch -= Time.deltaTime;

        if (gameObject.GetComponent<Telekinesis>().telekinesisActive == true)
        {

            gravity.gravityScale = 0;

        }

        else if (fallingObjectIsTrue == true && gameObject.GetComponent<Telekinesis>().telekinesisActive == true)
        {
            gravity.gravityScale = 0;
        }


        else if (fallingObjectIsTrue == true)
        {
            gravity.gravityScale = 1;
        }


    }
}
