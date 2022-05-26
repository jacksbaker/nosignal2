using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    public string levelToLoad;

    public float stopwatch;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallingObject" || collision.tag == "Spike")
        {
            gameObject.SetActive(false);
            Application.LoadLevel(levelToLoad);

        }
    }

}
