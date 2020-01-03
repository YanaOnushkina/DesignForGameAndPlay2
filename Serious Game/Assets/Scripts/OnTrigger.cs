using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    bool onTrigger;
    public GameObject correctUI;
    public GameObject wrongUI;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        Debug.Log("PLAYER TRIGGER ENTER");
        if (other.tag == "Correct_Choice")
        {
            StartCoroutine(Countdown(3, "correct"));
        }

        if (other.tag == "Wrong_Choice")
        {
            StartCoroutine(Countdown(3, "wrong"));
        }
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        Debug.Log("PLAYER TRIGGER EXIT");
    }
    IEnumerator Countdown(int seconds, string choice)
    {
        int count = seconds;

        while (count > 0 && onTrigger)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1);
            count--;
        }

        Debug.Log(onTrigger);
        if (choice == "correct" && onTrigger)
        {
            Debug.Log("Correct Choice");
            correctUI.SetActive(true);
        }

        if (choice == "wrong" && onTrigger)
        {
            Debug.Log("Wrong Choice");
            wrongUI.SetActive(true);
        }
    }
}
