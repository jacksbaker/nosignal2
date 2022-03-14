using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hypnosis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("J.Y. Park");
        Command playerScript = thePlayer.GetComponent<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void followPlayer()
    {
        Command.followPlayer = true;
    }

}
