using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material material;

    public void ChangeColor(Color color)
    {
        material.color = color;
    }
}
