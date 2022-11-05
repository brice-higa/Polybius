using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnHandler : MonoBehaviour
{

    public float DespawnRange = 30f;
    public float distanceFromPlayer;
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
        distanceFromPlayer = Vector3.Distance(player.transform.position, this.gameObject.transform.position); 

        //Debug.Log("Player: " + player.transform.position); // Debug notes: seems like both positions are being captured correctly
        //Debug.Log(this.gameObject.name + " " + this.gameObject.transform.position);
        //Debug.Log(distance);

        // If far enough from the player
        if (DespawnRange < distanceFromPlayer) 
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
