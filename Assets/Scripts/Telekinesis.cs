using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekinesis : MonoBehaviour
{
    public bool telekinesisActive;
    public float timer;
    public float moveSpeed = 15;
 

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        telekinesisActive = false;


        
    }

    // Update is called once per frame
    void Update()
    {


        timer = timer - Time.deltaTime;

        if (Input.GetKey("t"))
        {
            timer = 5;
            telekinesisActive = true;



        }

        else if (Input.GetButtonDown("Fire1"))
        {
            telekinesisActive = false;

        }

        else if (timer >= 0 && telekinesisActive == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            telekinesisActive = false;
        }
    }
}
