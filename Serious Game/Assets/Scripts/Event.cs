using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public GameObject panel;
    public void Deactivate()
    {
        panel.SetActive(false);
    }
}
