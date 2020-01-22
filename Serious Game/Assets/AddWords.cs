using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddWords : MonoBehaviour
{
    public Text text;
    public GameObject cube;

    public GameObject wrong;
    public GameObject correct;


    public List<string> texts = new List<string>(new string[] { "Apple", "Flowers", "Shirt", "Socks", "Cat", "Sunglasses", "Pancake" });

    public int score = 0;
    public int wrongS = 0;

    bool buttonPushed = false;

    public void AddWord()
    {
        if (!buttonPushed)
        {
            Text buttonText = this.gameObject.GetComponentInChildren(typeof(Text)) as Text;
            if (texts.Contains(buttonText.text))
            {
                score += 1;
            }
            else
            {
                wrongS += 1;
            }
            text.text = text.text + "        " + buttonText.text;
            buttonPushed = true;
        }
    }
}
