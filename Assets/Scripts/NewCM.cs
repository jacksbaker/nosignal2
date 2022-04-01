using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCM : MonoBehaviour
{
    public GameObject player;
    public GameObject camera1;
    public int cameraMoveAmount = 22;
    public int cameraMove2;

    void Update()
    {
        
        var playerViewportPosition = Camera.main.WorldToViewportPoint(player.transform.position);

        
        if (playerViewportPosition.x > 1f)
        {
            Camera.main.transform.position += Vector3.right * cameraMoveAmount; 

            
        }
        
        else if (playerViewportPosition.x < 0f)
        {
            Camera.main.transform.position += Vector3.left * cameraMoveAmount; 

            
        }

    }
}