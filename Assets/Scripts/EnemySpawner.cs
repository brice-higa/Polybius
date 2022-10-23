using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{

    public float enemyRate = 5; //seconds until new enemy appears
    public float nextEnemy = 2; // first enemy spawned in 5 seconds.
    public GameObject enemyPrefab;
    public float spawnDistance = 10f;
    public static int enemiesKilled = 0;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
        if(nextEnemy <= 0)
        {
            nextEnemy = enemyRate; // next enemy in x seconds. 
            
            //modify spawn rate
            /*enemyRate *= 0.9f;
            if(enemyRate < 2)
                enemyRate = 2;*/
                
            Vector3 offset = Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized*spawnDistance;
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }
    }

    void OnGUI(){
            
            GUI.Label(new Rect(0,15,100,50), "Score: " + enemiesKilled);
               


        }
}
