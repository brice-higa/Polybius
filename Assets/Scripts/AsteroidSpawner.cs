using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AsteroidSpawner : MonoBehaviour
{

    public float asteroidRate = 4; //seconds until new asteroid appears
    public float nextAsteroid = 1;
    public GameObject copperAsteroidPrefab;
    public GameObject ironAsteroidPrefab;
    public float spawnDistance = 20f;
    private System.Random rnd = new System.Random();

    // Update is called once per frame
    void Update()
    {
        nextAsteroid -= Time.deltaTime;
        if(nextAsteroid <= 0)
        {
            nextAsteroid = asteroidRate;
            asteroidRate *= 1f; //no change to asteroid spawn rate
            if(asteroidRate < 2)
                asteroidRate = 2;
                
            Vector3 offset = UnityEngine.Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized*spawnDistance;

            if (rnd.NextDouble() < 0.7f)
                Instantiate(copperAsteroidPrefab, transform.position + offset, Quaternion.identity);
            else
                Instantiate(ironAsteroidPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
