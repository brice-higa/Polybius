using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurvivalTime : MonoBehaviour
{

    float cntdnw = 0f;
    public TMP_Text disvar;
    public string Minutes;
    public string Seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        cntdnw = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        cntdnw += Time.deltaTime;

        double b = System.Math.Round(cntdnw, 2);
        //disvar.text = b.ToString();
        float minutes = Mathf.FloorToInt(cntdnw / 60);
        Minutes = minutes.ToString();
        Minutes = Minutes.PadLeft(2, '0');
        float seconds = Mathf.FloorToInt(cntdnw % 60);
        Seconds = seconds.ToString();
        Seconds = Seconds.PadLeft(2, '0');

        disvar.text = "Time Survived: " + Minutes + ":" + Seconds;

    }
}
