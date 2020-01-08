using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        FindObjectOfType<GameManager>().StroopTest();
    }
}
