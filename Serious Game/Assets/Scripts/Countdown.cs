using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdown;

    void Update()
    {
        countdown.text = "5";
        if (Time.time > 1)
        {
            countdown.text = "4";
        }
        if (Time.time > 2)
        {
            countdown.text = "3";
        }
        if (Time.time > 3)
        {
            countdown.text = "2";
        }
        if (Time.time > 4)
        {
            countdown.text = "1";
        }
        if (Time.time > 5)
        {
            countdown.text = "0";
        }
        if (Time.time > 6)
        {

        }
    }
}
