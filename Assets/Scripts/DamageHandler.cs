using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
    {
       public int health = 1;
       public float invulnPeriod = 0;
       float invulnTimer = 0; //seconds of invulnerability after crashing.
       int correctLayer = 0;

       void Start(){

        correctLayer = gameObject.layer;

            
        }

        void OnTriggerEnter2D(){
            Debug.Log("Trigger!");

            
            health--; //reduce health by 1 point
            invulnTimer = 1.5f; // 1.5 seconds of invulnerability after collision
            gameObject.layer = 8; //changing to invulnerable layer

        }

        void Update() {
            
            invulnTimer -= Time.deltaTime; //reducing invulnerable time.
            
            if (invulnTimer <= 0)
            {
                gameObject.layer = correctLayer;
            }

            if (health <= 0){
                Die();
            }
        }

        void Die(){
            Destroy(gameObject);
        }
}
