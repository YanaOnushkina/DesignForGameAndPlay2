using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdown;
    // Update is called once per frame
    void Update()
    {
        countdown.text = "3";
        if (Time.time > 1)
        {
            countdown.text = "2";
        }
        if (Time.time > 2)
        {
            countdown.text = "1";
        }
        if (Time.time > 3)
        {
            countdown.text = "";
        }

        //Might need another if here if time ran out but player not chosen an option 
    }
}
