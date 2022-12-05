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

    // Start is called before the first frame update
    void Start()
    {
        fireDelay = 0.5f;
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        
        // Decrease cooldown
        coolDownTimer -= Time.deltaTime;

        // Find all enemies
        myTarget = GameObject.FindWithTag("Enemy");

        // Find nearest enemy
        /*var maxDistance = 100000;
        foreach (GameObject enemy in targets)
        {
            var distance = Vector3.Distance(enemy.transform.position, transform.position);
            if (distance < maxDistance)
            {
                mytarget = enemy;
                maxDistance = distance;
            }
        }*/

        if(myTarget == null)
        {
            return;
        }

        // Shoot at enemy, is cooldown is up
        if (coolDownTimer <= 0)
        {
            // Reset cooldown
            coolDownTimer = fireDelay;

            //Vector2 direction = myTarget.transform.position - transform.position;
            //direction.Normalize();
            //GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);

            
            //bullet.transform.LookAt(myTarget.transform);
            
            
            Quaternion rotation = Quaternion.LookRotation(myTarget.transform.position - bullet.transform.position, bullet.transform.TransformDirection(Vector3.back));
            bullet.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

            bullet.layer = bulletLayer;

        }
        
    }
}
