using System.Collections;
using
System.Collections.Generic;
using
UnityEngine;
using
UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public float CountdownTime;
    public float Countsetting = 1f;
    public bool RunFaster = false;
    public Text time; void Start()
    {
        time = GetComponent<Text>();
    }
    void Update()
    {
        Countsetting -= Time.deltaTime;
        if (Countsetting <= 0 && CountdownTime > 0)
        {
            CountdownTime -= 1; if
            (RunFaster == false)
            {
                Countsetting = 0.1f;
            }
            if (RunFaster == true)
            {
                Countsetting = 0.1f;
            }
        }
        time.text = CountdownTime.ToString("0");
    }
}