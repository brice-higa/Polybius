using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerPhysics : MonoBehaviour
{
    public int health = 2;
    public float invulnPeriod = 1; //seconds of invulnerability after crashing.
    float invulnTimer = 0;
    bool canBeDamaged = true;
    //int correctLayer = 0;

    void Start()
    {

        //correctLayer = gameObject.layer;
        canBeDamaged = true;

    }

    void OnCollisionEnter2D()
    {

        Debug.Log("Collide!");

        if (canBeDamaged)
        {
            health--; //reduce health by 1 point
            canBeDamaged = false;
            invulnTimer = invulnPeriod;
        }

        //invulnTimer = 1.5f; // 1.5 seconds of invulnerability after collision
        //gameObject.layer = 8; //changing to invulnerable layer

    }

    void Update()
    {

        invulnTimer -= Time.deltaTime; //reducing invulnerable time.

        if (invulnTimer <= 0)
        {
            //gameObject.layer = correctLayer;
            canBeDamaged = true;
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
