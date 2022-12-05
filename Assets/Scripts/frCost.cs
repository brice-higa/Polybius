using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class frCost : MonoBehaviour
{
    public TextMeshProUGUI cost;

    // Update is called once per frame
    void Update()
    {
        int num = UpgradeMenu.FRcost;
        cost.text = num + " Iron";
    }
}
