using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDamageHandler : MonoBehaviour
{
    public int health = 3;
    public float invulnPeriod = 0;
    float invulnTimer = 0; //seconds of invulnerability after crashing.
    int correctLayer = 0;
    SpriteRenderer spriteRend;
    public GameObject materialDrop;


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


        health--; //reduce health by 1 point


    }

    void Update()
    {

        invulnTimer -= Time.deltaTime; //reducing invulnerable time.

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(materialDrop, transform.position, Quaternion.identity);

    }


}
