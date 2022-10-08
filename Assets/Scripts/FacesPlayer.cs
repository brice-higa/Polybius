using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            GameObject go = GameObject.Find("PlayerShip");

            if(go != null)
            {
                player = go.transform;
            }
        }

        if(player == null)
        {return;} //looking for player in next frame

        transform.rotation = Quaternion.Euler(0, 0, 180*Time.time); //rotating enemy ship
    }
}
