using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform myTarget;
    private GameObject player;

    // Update is called once per frame
    void Update()
    {

        // find player
        player = GameObject.FindWithTag("Player");
        
        // if player exists
        if (player != null)
        {
            // convert gameObject to transform
            myTarget = player.transform;

            // move camera
            Vector3 targPos = myTarget.position;
            targPos.z = transform.position.z;
            transform.position = targPos; 
        }
    }

}
