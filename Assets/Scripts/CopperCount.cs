using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CopperCount : MonoBehaviour
{

    public TextMeshProUGUI count;

    // Update is called once per frame
    void Update()
    {
        int num = DamageHandler.copper;
        count.text = "Copper: " + num;
    }
}
