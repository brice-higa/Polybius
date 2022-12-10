using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Vector3 bulletOffset = new Vector3(0, 1f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;
    public static float fireDelay = 0.7f;
    float coolDownTimer = 0;

    void Start()
    {
        fireDelay = 0.7f;
        bulletLayer = gameObject.layer;
    }


    // Update is called once per frame
    void Update()
    {
        coolDownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && coolDownTimer <= 0)
        {

            //Debug.Log("FIREEEEE");
            coolDownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;

        }
    }
}
