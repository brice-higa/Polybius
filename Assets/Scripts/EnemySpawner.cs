using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    float enemyRate = 5; //seconds until new enemy appears
    float nextEnemy = 1;
    public GameObject enemyPrefab;
    public float spawnDistance = 10f;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
        if(nextEnemy <= 0)
        {
            nextEnemy = enemyRate;
            enemyRate *= 0.9f;
            if(enemyRate < 2)
                enemyRate = 2;
                
            Vector3 offset = Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized*spawnDistance;
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
