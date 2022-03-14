using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectPressurePlate : MonoBehaviour
{
    // Start is called before the first frame update
    //public float stopwatch;
     private GameObject fallingObjectScript;

     private GameObject player;

    void Start()
    {
            GameObject fallingObejct = GameObject.Find("Object");
            FallingObject fallingObjectScript = fallingObejct.GetComponent<FallingObject>();

        player = GameObject.Find("Player");

    }

        // Update is called once per frame
        void Update()
        {
            //stopwatch -= Time.deltaTime;

            //if (stopwatch <= 5 || stopwatch >= 0)
            //{

            //}
        }


        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && player.GetComponent<StopTime>().stopTime != true)
            {
            //stopwatch = 5;
            FallingObject.fallingObjectIsTrue = true;
            }
        }

    
}
