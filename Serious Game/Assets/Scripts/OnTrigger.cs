using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    bool onTriggerC;
    bool onTriggerF;

    public GameManager manager;

    public GameObject canvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Correct_Choice")
        {
            onTriggerC = true;
            StartCoroutine(Countdown(1, "correct"));
        }

        if (other.tag == "Wrong_Choice")
        {
            onTriggerF = true;
            StartCoroutine(Countdown(1, "wrong"));
        }
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerC = false;
        onTriggerF = true;
    }
    IEnumerator Countdown(int seconds, string choice)
    {
        int count = seconds;

        while (count > 0 && (onTriggerC || onTriggerF))
        {
            yield return new WaitForSeconds(1);
            count--;
        }
        if (choice == "correct" && onTriggerC)
        {
            canvas.GetComponent<WinOrLoose>().CorrectWrong("correct");
            onTriggerC = false;
            onTriggerF = false;

        }

        if (choice == "wrong" && onTriggerF)
        {
            canvas.GetComponent<WinOrLoose>().CorrectWrong("wrong");
            manager.GetComponent<GameManager>().scoreCounter -= 1;
            onTriggerC = false;
            onTriggerF = false;
        }
    }
}
