using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour
{
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GameObject.Find("Camera movement trigger");
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger.GetComponent<CamMovementActivation>().cam == true && Input.GetKey("d"))
        {
            Debug.Log("move cam");
            transform.position += new Vector3(0.069f, 0f, 0f);
        }

        if (trigger.GetComponent<CamMovementActivation>().cam == true && Input.GetKey("a"))
        {
            Debug.Log("move cam");
            transform.position += new Vector3(-0.069f, 0f, 0f);
        }
    }
}
