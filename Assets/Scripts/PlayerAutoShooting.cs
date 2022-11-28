using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoShooting : MonoBehaviour
{

    public Vector3 bulletOffset = new Vector3(0, 1f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;
    public float fireDelay = 0.5f;
    float coolDownTimer = 0;
    public GameObject myTarget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        // Decrease cooldown
        coolDownTimer -= Time.deltaTime;

        // Find all enemies
        var targets = gameObject.FindGameOjbectsWithTag("Enemy");

        // Find nearest enemy
        var maxDistance = 100000;
        for (var enemy : GameObject in targets)
        {
            var distance = Vector3.Distance(enemy.transform.position, transform.position);
            if (distance < maxDistance)
            {
                mytarget = enemy;
                maxDistance = distance;
            }
        }

        // Shoot at enemy, is cooldown is up
        if (coolDownTimer <= 0)
        {
            // Reset cooldown
            coolDownTimer = fireDelay;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, myTarget.transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;

        }
        */
    }
}
