using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{   

    public Vector3 bulletOffset =  new Vector3(0, 1f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.5f;
    float coolDownTimer = 0;

    // Update is called once per frame
    void Update(){
        coolDownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && coolDownTimer <= 0){
            //Fire:
            
            Debug.Log("FIREEEEE");
            coolDownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);

        }
    }
}
