using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnHandler : MonoBehaviour
{

    public float DespawnRange = 30f;
    public float distance;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // find the player
        player = GameObject.FindWithTag("Player");

        // calculate distance between player and this object
        float distance = Vector3.Distance(player.transform.position, this.gameObject.transform.position); // bug: this is always 0 for some reason

        // If far enough from the player
        if (DespawnRange < distance) //bug: this doesn't trigger even if I manually set distance to 100 in the inspector
        {
            Debug.Log("Despawning" + this.gameObject.name);
            DespawnObject(); // destroy game object without giving points or drops.
        }

    }

    void DespawnObject()
    {
        Destroy(this.gameObject);
        Debug.Log("Despawned" + this.gameObject.name);
    }
}
