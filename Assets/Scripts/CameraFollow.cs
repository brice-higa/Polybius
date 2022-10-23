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

        player = GameObject.FindWithTag("Player");
        myTarget = player.transform;

        if (myTarget != null)
        {
            Vector3 targPos = myTarget.position;
            targPos.z = transform.position.z;
            transform.position = targPos; 
        }
    }

}
