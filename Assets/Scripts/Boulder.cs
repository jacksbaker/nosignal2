using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{

    public bool isBoulderTrue;

    private Rigidbody2D gravity;

    public float stopwatch;

    public float moveSpeed = 7f;

    [SerializeField] private LayerMask ground;

    private Rigidbody2D rb;
    private CircleCollider2D coll;

   


    // Start is called before the first frame update
    void Start()
    {

        isBoulderTrue = false;
        gravity = GetComponent<Rigidbody2D>();

        Telekinesis fallingObjectScript = gameObject.GetComponent<Telekinesis>();

        coll = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
         
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch -= Time.deltaTime;

        if (gameObject.GetComponent<Telekinesis>().telekinesisActive == true)
        {

            gravity.gravityScale = 0;

        }

        else if (isBoulderTrue == true && gameObject.GetComponent<Telekinesis>().telekinesisActive == true)
        {
            gravity.gravityScale = 0;
        }


        else if (isBoulderTrue == true)
        {
            gravity.gravityScale = 1;
        }

        



            
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(5 * moveSpeed, rb.velocity.y);
    }


}
