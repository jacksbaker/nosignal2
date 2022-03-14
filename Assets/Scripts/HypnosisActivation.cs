using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HypnosisActivation : MonoBehaviour
{

    public GameObject coll;
    public float timer;

    public GameObject panel;

    //static public bool followPlayer;
    static public bool ride;

    //public NavMeshAgent enemy;
    //public Transform Player;

    //Vector2 newPosition;

    public float speed = 1.5f;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        GameObject coll = GameObject.Find("coll");
        timer = 0f;

        GameObject panel = GameObject.Find("Panel");

        panel.SetActive(false);

        //newPosition = transform.position;

        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        timer = timer - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.H))
        {
            
            coll.SetActive(true);
            timer = 5;

        }

        else if(ride == true)
        {

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(timer > 0)
        {
            if (collision.tag == "Hypnosis")
            {
                Debug.Log("Hypnosis");
                panel.SetActive(true);
                coll.SetActive(false);
            }
        }
        
    }

}

