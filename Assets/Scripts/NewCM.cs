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
        // convert player position to a viewport point
        var playerViewportPosition = Camera.main.WorldToViewportPoint(player.transform.position);

        // is the player offscreen to the right?
        if (playerViewportPosition.x > 1f)
        {
            Camera.main.transform.position += Vector3.right * cameraMoveAmount; // move right by move amount

            //Camera.main.transform.position = Vector3.Lerp(camera1.transform.position, Vector3.right * cameraMoveAmount, 1f);
        }
        // is the player offscreen to the left?
        else if (playerViewportPosition.x < 0f)
        {
            //Camera.main.transform.position += Vector3.left * cameraMoveAmount; // move left by move amount

            Camera.main.transform.position = Vector3.Lerp(camera1.transform.position, Vector3.left * cameraMoveAmount, 1f);
        }

    }
}