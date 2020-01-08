using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLoose : MonoBehaviour
{

    public GameObject correctUI;
    public GameObject wrongUI;

    public void CorrectWrong(string answer)
    {
        if (answer == "correct")
        {
            correctUI.SetActive(true);
        }

        if (answer == "wrong")
        {
            wrongUI.SetActive(true);
        }
    }
}
