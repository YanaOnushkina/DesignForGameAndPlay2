using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen2 : MonoBehaviour
{

    void OnMouseDown()
    {
        SceneManager.LoadScene("PT_Memory");
    }
}
