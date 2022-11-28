using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0; //seconds of invulnerability after crashing.
    int correctLayer = 0;
    int maxHealth = 30;
    public static int enemiesKilled = 0;
    private int copper = 0;
    private int iron = 0;
    SpriteRenderer spriteRend;


    void Start()
    {

        // When the player spawns, these values should be set to zero to prevent carry-over from previous game
        enemiesKilled = 0;
        copper = 0;
        iron = 0;
        
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

        Debug.Log("Trigger by " + other.gameObject.tag);

        if (other.gameObject.tag == "healthTag")
        {
            health = health + 5;
            if (health > maxHealth)
                health = maxHealth;

            Debug.Log("Trigger by " + other.gameObject + " and increased health by 5");
        }
        else if (other.gameObject.tag == "copperTag")
        {
            copper++;
        }
        else if (other.gameObject.tag == "ironTag")
        {
            iron++;
        }
        else
        {
            health--; //reduce health by 1 point
            invulnTimer = 1.5f; // 1.5 seconds of invulnerability after collision
            gameObject.layer = 8; //changing to invulnerable layer
        }


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
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void OnGUI()
    {
        if (health > 0)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Health: " + health);
            GUI.Label(new Rect(0, 15, 100, 50), "Score: " + enemiesKilled);
            GUI.Label(new Rect(0, 30, 100, 50), "Copper: " + copper);
            GUI.Label(new Rect(0, 45, 100, 50), "Iron: " + iron);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "GAME OVER");
            Debug.Log("Game Over!"); //This does not trigger when the player dies, probably because this script is attatched to the player which no longer exists.
        }

    }
}
