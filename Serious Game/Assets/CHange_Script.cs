using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHange_Script : MonoBehaviour
{
    public Text newtext;
    public void Changetext(string text)
    {
        newtext.text = text.ToString();
    }
}
