using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float cntdnw = 10.0f;
    public Text disvar;

    void Update()
    {
        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }
        double b = System.Math.Round(cntdnw, 0);
        disvar.text = b.ToString();
        if (cntdnw < 0)
        {
            Debug.Log("Completed");
        }
    }
}