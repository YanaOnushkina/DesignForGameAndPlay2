using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveFals : MonoBehaviour
{
    public GameObject panel;
    public void setActive()
    {
        panel.SetActive(false);
    }
}
