using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen3 : MonoBehaviour
{
    public GameObject canvas;

    void OnMouseDown()
    {
        canvas.SetActive(true);
    }
}
