using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hpCost : MonoBehaviour
{

    public TextMeshProUGUI cost;

    // Update is called once per frame
    void Update()
    {
        int num = UpgradeMenu.HPcost;
        cost.text = num + " Copper";
    }
}
