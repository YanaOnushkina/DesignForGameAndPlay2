using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    bool onTriggerC;
    bool onTriggerF;

    public GameObject canvas;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("PLAYER TRIGGER ENTER");
        if (other.tag == "Correct_Choice")
        {
            onTriggerC = true;
            StartCoroutine(Countdown(3, "correct"));
        }

        if (other.tag == "Wrong_Choice")
        {
            onTriggerF = true;
            StartCoroutine(Countdown(3, "wrong"));
        }
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerC = false;
        onTriggerF = true;
        Debug.Log("PLAYER TRIGGER EXIT");
    }
    IEnumerator Countdown(int seconds, string choice)
    {
        int count = seconds;

        while (count > 0 && (onTriggerC || onTriggerF))
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1);
            count--;
        }

        Debug.Log(onTriggerC);
        Debug.Log(onTriggerF);
        if (choice == "correct" && onTriggerC)
        {
            Debug.Log("Correct Choice");
            canvas.GetComponent<WinOrLoose>().CorrectWrong("correct");
        }

        if (choice == "wrong" && onTriggerF)
        {
            Debug.Log("Wrong Choice");
            canvas.GetComponent<WinOrLoose>().CorrectWrong("wrong");
        }
    }
}
