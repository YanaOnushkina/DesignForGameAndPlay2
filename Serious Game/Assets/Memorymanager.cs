using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memorymanager : MonoBehaviour
{
    int randomnumber;
    int counter = 0;

    public List<string> textsub = new List<string>(new string[] { "Apple", "Flowers", "Shirt", "Socks", "Cat", "Sunglasses", "Pancake" });
    public List<string> text = new List<string>(new string[] { "Apple", "Flowers", "Shirt", "Socks", "Cat", "Sunglasses", "Pancake" });
    public List<string> falsewords = new List<string>(new string[] { "Pants", "Banana", "Roses", "Daisy", "Dog", "Glasses", "Cake" });

    public List<string> buttonWOrds = new List<string>();

    public GameObject word_1;
    public GameObject word_2;
    public GameObject word_3;
    public GameObject word_4;
    public GameObject word_5;
    public GameObject word_6;
    public GameObject word_7;

    public GameObject button_1;
    public GameObject button_2;
    public GameObject button_3;
    public GameObject button_4;
    public GameObject button_5;
    public GameObject button_6;
    public GameObject button_7;
    public GameObject button_8;
    public GameObject button_9;
    public GameObject button_10;

    int length = 6;

    int whichList;

    int lengthText = 6;
    int lengthFalsewords = 6;

    public int correctWOrdsCount = 0; 

    string word;

    public void Word()
    {
        while (counter < 10)
        {
            whichList = Random.Range(0, 2);
            Debug.Log(whichList);
            if (whichList == 0 && text.Count > 0)
            {
                randomnumber = Random.Range(0, text.Count - 1);
                Debug.Log(text[randomnumber]);
            }
            if (whichList == 1 && falsewords.Count > 0)
            {
                randomnumber = Random.Range(0, falsewords.Count - 1);
                Debug.Log(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if(counter == 0 && whichList == 0)
            {
                Text w1 = button_1.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 0 && whichList == 1)
            {
                Text w1 = button_1.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 1 && whichList == 0)
            {
                Text w1 = button_2.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 1 && whichList == 1)
            {
                Text w1 = button_2.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 2 && whichList == 0)
            {
                Text w1 = button_3.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 2 && whichList == 1)
            {
                Text w1 = button_3.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 3 && whichList == 0)
            {
                Text w1 = button_4.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 3 && whichList == 1)
            {
                Text w1 = button_4.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 4 && whichList == 0)
            {
                Text w1 = button_5.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 4 && whichList == 1)
            {
                Text w1 = button_5.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 5 && whichList == 0)
            {
                Text w1 = button_6.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 5 && whichList == 1)
            {
                Text w1 = button_6.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 6 && whichList == 0)
            {
                Text w1 = button_7.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 6 && whichList == 1)
            {
                Text w1 = button_7.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 7 && whichList == 0)
            {
                Text w1 = button_8.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 7 && whichList == 1)
            {
                Text w1 = button_8.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 8 && whichList == 0)
            {
                Text w1 = button_9.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 8 && whichList == 1)
            {
                Text w1 = button_9.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            if (counter == 9 && whichList == 0)
            {
                Text w1 = button_10.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
                correctWOrdsCount += 1;
            }
            if (counter == 9 && whichList == 1)
            {
                Text w1 = button_10.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(falsewords[randomnumber]);
                buttonWOrds.Add(falsewords[randomnumber]);
            }
            counter += 1;
            if (whichList == 0)
            {
                word = text[randomnumber];
                Debug.Log(text.Count);
                text.Remove(word);
                Debug.Log(text.Count);
            }
            if (whichList == 1)
            {
                word = falsewords[randomnumber];
                Debug.Log(falsewords.Count);
                falsewords.Remove(word);
                Debug.Log(falsewords.Count);
            }
        }
        counter = 0;
        text = textsub;
        length = 6;
        while (counter < 7)
        {
            randomnumber = Random.Range(0, length);
            if (counter == 0) 
            {
                Text w1 = word_1.GetComponentInChildren(typeof(Text)) as Text;
                w1.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 1)
            {
                Text w2 = word_2.GetComponentInChildren(typeof(Text)) as Text;
                w2.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 2)
            {
                Text w3 = word_3.GetComponentInChildren(typeof(Text)) as Text;
                w3.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 3)
            {
                Text w4 = word_4.GetComponentInChildren(typeof(Text)) as Text;
                w4.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 4)
            {
                Text w5 = word_5.GetComponentInChildren(typeof(Text)) as Text;
                w5.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 5)
            {
                Text w6 = word_6.GetComponentInChildren(typeof(Text)) as Text;
                w6.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (counter == 6)
            {
                Text w7 = word_7.GetComponentInChildren(typeof(Text)) as Text;
                w7.GetComponent<CHange_Script>().Changetext(text[randomnumber]);
            }

            if (length >= 0)
            {
                Debug.Log( "randomnumber" + randomnumber);
                Debug.Log("length" + length);
                text.Remove(text[randomnumber]);
            }
            counter += 1;
            length -= 1;
        }
        word_1.SetActive(true);
    }
}
