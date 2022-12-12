using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoShooting : MonoBehaviour
{

    public Vector3 bulletOffset = new Vector3(0, 1f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;
    public static float fireDelay = 0.5f;
    float coolDownTimer = 0;
    public GameObject myTarget;
    AudioSource m_shootingSound;

    // Start is called before the first frame update
    void Start()
    {
        fireDelay = 0.5f;
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        
        m_shootingSound = GetComponent<AudioSource>();

        // Decrease cooldown
        coolDownTimer -= Time.deltaTime;

        // Find a enemy
        myTarget = GameObject.FindWithTag("Enemy");


        // if there are no enemies, target an asteriod
        if(myTarget == null)
        {
            myTarget = GameObject.FindWithTag("Asteriod");
        }

        // if there are no valid targets, don't whoot
        if(myTarget == null)
        {
            return;
        }

        // Shoot at enemy, is cooldown is up
        if (coolDownTimer <= 0)
        {
            m_shootingSound.Play();
            
            // Reset cooldown
            coolDownTimer = fireDelay;

            // create bullet
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            
            // rotate bullet towards target 
            Quaternion rotation = Quaternion.LookRotation(myTarget.transform.position - bullet.transform.position, bullet.transform.TransformDirection(Vector3.back));
            bullet.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

            // set bullet layer
            bullet.layer = bulletLayer;

        }
        
    }
}
