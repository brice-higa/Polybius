using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //ROTATE the ship
        //Grab our rotation quartenion
        Quaternion rot = transform.rotation;
        //Grab the Z euler angle
        float z = rot.eulerAngles.z;
        //Change the Z angle based on input
        z += -Input.GetAxis("Horizontal")*rotSpeed*Time.deltaTime;
        //Recreate the quartenion
        rot = Quaternion.Euler(0,0,z);
        //Feed the quartenion into our rotation
        transform.rotation = rot;

        //MOVE the ship
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical")*maxSpeed*Time.deltaTime, 0);
        pos += rot*velocity;
        transform.position = pos;
    }
}
