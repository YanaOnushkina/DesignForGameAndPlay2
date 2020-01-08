using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void CallManager()
    {
        Debug.Log("CALL MANAGER");
        FindObjectOfType<GameManager>().StroopTest(); 
    }
}
