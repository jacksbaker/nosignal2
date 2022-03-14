using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisablility : MonoBehaviour
{
    public bool invisability;
    public float timer;
    public float fadeSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        invisability = false;
    }

    // Update is called once per frame
    void Update()
    {

        timer = timer - Time.deltaTime;

        if (Input.GetKey("i"))
        {

            invisability = true;
            timer = 5f;

        }

        if (timer >= 0 && invisability == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
            //Color color = this.GetComponent <SpriteRenderer>().material.color;
            //color.a -= Time.deltaTime * fadeSpeed;
            //this.GetComponent <SpriteRenderer>().material.color = color;
        }

        else if(timer <= 0)
        {
            invisability = false;
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}
