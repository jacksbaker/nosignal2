using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderActivation : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Boulder boulder;

    void Start()
    {


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
            Debug.Log("Player");
            boulder.isBoulderTrue = true;

        }
    }
}
