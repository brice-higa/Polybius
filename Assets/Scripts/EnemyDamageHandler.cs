using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamageHandler;
using System;

public class EnemyDamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0; //seconds of invulnerability after crashing.
    int correctLayer = 0;
    SpriteRenderer spriteRend;
    public GameObject healthDrop;
    private System.Random rnd = new System.Random();


    void Start()
    {
        correctLayer = gameObject.layer;

        spriteRend = GetComponent<SpriteRenderer>();
        //This only gets the renderer on the parent object.
        //It doesn't work for children.
        if (spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

            if (spriteRend == null)
            {
                Debug.LogError("Object '" + gameObject.name + "' has no sprite renderer");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Trigger!");


        // If this collides with something other than a pickup item, asteriod, or enemy
        if (other.gameObject.tag != "healthTag" && other.gameObject.tag != "ironTag" && other.gameObject.tag != "copperTag" && other.gameObject.tag != "Asteriod" && other.gameObject.tag != "Enemy")
        {
            health--; //reduce health by 1 point
        }
        //invulnTimer = 1.5f; // 1.5 seconds of invulnerability after collision
        gameObject.layer = 8; //changing to invulnerable layer

    }

    void Update()
    {

        invulnTimer -= Time.deltaTime; //reducing invulnerable time.

        if (invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
            if (spriteRend != null)
            {
                spriteRend.enabled = true;
            }
        }
        else
        {
            if (spriteRend != null)
            {
                spriteRend.enabled = !spriteRend.enabled;
            }
        }

        if (health <= 0)
        {
            Die();
            enemiesKilled++;
        }
    }

    void Die()
    {
        Destroy(gameObject);
        if (rnd.NextDouble() < 0.1f)
            Instantiate(healthDrop, transform.position, Quaternion.identity);

    }


}
