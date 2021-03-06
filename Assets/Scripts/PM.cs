using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;
    private SpriteRenderer sprite;
    private ParticleSystem part;

    [SerializeField] private LayerMask jumpableGround;

    [SerializeField] private float dirX = 0f;
    static public float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 10f;
    //[SerializeField] private float jumpCounter = 0f;
    public bool canDoubleJump = false;

    public bool facingRight = true;

    static public bool speedBuff;
    static public bool slowness;

    public string startPoint;

    private static bool playerExists;

    public bool superSpeed;

    public float stopwatch;

    public bool spin;

    private float stopwatch2;





    private enum MovementState { idle, running, jumping, falling, spinleft, speed }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
        part = GetComponent<ParticleSystem>();

        facingRight = true;

        speedBuff = false;
        slowness = false;


    }

    // Update is called once per frame
    void Update()
    {

        stopwatch -= Time.deltaTime;
        stopwatch2 -= Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Q))
        {

            superSpeed = true;
            stopwatch = 1;

        }


        if (stopwatch < 0)
        {
            superSpeed = false;
        }




        dirX = Input.GetAxisRaw("Horizontal");

        if (superSpeed == true && stopwatch >= 0)
        {
            
            moveSpeed = 16f;


            rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        }

        else
        {
            moveSpeed = 7f;
            rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        }


        if (Input.GetKeyDown("space") && IsGrounded())
        {
            //jumpCounter++;
            GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            canDoubleJump = true;

            //if(jumpCounter <= 2)
            //{
            //    jumpCounter++;
            //    GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            //}
        }

        else if (Input.GetKeyDown("space") && canDoubleJump == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            canDoubleJump = false;
            //jumpCounter = 0;
        }

        if(Input.GetKeyDown("b"))
        {
            //Debug.Log("spin");
            spin = true;
            stopwatch2 = 3f;
        }

        else if(stopwatch2 <= 0)
        {
            spin = false;
        }


        UpdateAnimationUpdate();
    }


    private void UpdateAnimationUpdate()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;

            if (!facingRight)
            {
                flip();
                facingRight = true;
            }
        }

        else if (dirX < 0f)
        {
            state = MovementState.running;
            //Debug.Log("Running");


            if (facingRight)
            {
                flip();
            }
        }

        else
        {
            //Debug.Log("Idle");
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }

        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        if(spin == true)
        {
            Debug.Log("spin");
            state = MovementState.spinleft;
        }

        if(superSpeed == true)
        {
            state = MovementState.speed;
        }

        //else if (facingRight && (Input.GetKey("b")))
        //{
        //    state = MovementState.spinright;
        //}


        anim.SetInteger("state", (int)state);

    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);


    }

    private void flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0, 180f, 0f);


    }
}


