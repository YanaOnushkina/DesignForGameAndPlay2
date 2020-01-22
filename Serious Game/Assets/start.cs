using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject cube;
    
    void Start()
    {
        cube.GetComponent<Memorymanager>().Word();
    }
}
