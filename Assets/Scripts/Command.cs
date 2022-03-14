using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{

    public float speed = 6f;
    private Vector3 target;

    static public bool followPlayer;

    //private Vector3 mousePosition;
    //public float moveSpeed = 7f;


    // Start is called before the first frame update
    void Start()
    {
        //target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
            }

            transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);

            //if (Input.GetMouseButton(0))
            //{
            //    mousePosition = Input.mousePosition;
            //    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
            //}



        }
    }
}
