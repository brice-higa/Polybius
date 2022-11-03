using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour
{

    public float enemyRate = 3; //seconds until new enemy appears
    public float nextEnemy = 2; // first enemy spawned in 5 seconds.
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public float spawnDistance = 10f;
    private System.Random rnd = new System.Random();

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
                
            Vector3 offset = UnityEngine.Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized*spawnDistance;
            if (rnd.NextDouble() < 0.75f)
                Instantiate(enemy1Prefab, transform.position + offset, Quaternion.identity);
            else
                Instantiate(enemy2Prefab, transform.position + offset, Quaternion.identity);
        }
    }

}
