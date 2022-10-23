using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public float asteroidRate = 5; //seconds until new asteroid appears
    public float nextAsteroid = 1;
    public GameObject asteroidPrefab;
    public float spawnDistance = 15f;

    // Update is called once per frame
    void Update()
    {
        nextAsteroid -= Time.deltaTime;
        if(nextAsteroid <= 0)
        {
            nextAsteroid = asteroidRate;
            asteroidRate *= 0.9f;
            if(asteroidRate < 2)
                asteroidRate = 2;
                
            Vector3 offset = Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized*spawnDistance;
            Instantiate(asteroidPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
