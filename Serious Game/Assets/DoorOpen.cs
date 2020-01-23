using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{

    void OnMouseDown()
    {
        SceneManager.LoadScene("PT_Game_1");
    }
}
