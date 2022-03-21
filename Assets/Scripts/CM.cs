using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour
{
    private GameObject player;

    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GameObject.Find("Camera movement trigger");

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger.GetComponent<CamMovementActivation>().cam == true && player.GetComponent<PM>().facingRight == true)
        {
            Debug.Log("move cam");
            transform.position += new Vector3(0.039f, 0f, 0f);
        }

        if (trigger.GetComponent<CamMovementActivation>().cam == true && player.GetComponent<PM>().facingRight != true)
        {
            Debug.Log("move cam");
            transform.position += new Vector3(-0.039f, 0f, 0f);
        }
    }
}
