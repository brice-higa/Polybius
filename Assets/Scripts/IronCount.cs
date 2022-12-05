using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IronCount : MonoBehaviour
{

    public TextMeshProUGUI count;

    // Update is called once per frame
    void Update()
    {
        int num = DamageHandler.iron;
        count.text = "Iron: " + num;
    }
}
