using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{   

    public Vector3 bulletOffset =  new Vector3(0, 1f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;
    public float fireDelay = 0.5f;
    float coolDownTimer = 0;
    Transform player;

    void Start(){
        bulletLayer = gameObject.layer;
    }


    // Update is called once per frame
    void Update(){

        if(player == null)
        {
            GameObject go = GameObject.FindWithTag("Player");

            if(go != null)
            {
                player = go.transform;
            }
        }


        coolDownTimer -= Time.deltaTime;

        if(coolDownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 5){
            //Fire:
            coolDownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;

        }
    }
}
