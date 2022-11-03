using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
