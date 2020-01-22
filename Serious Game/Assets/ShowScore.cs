using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
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
    int score;

    public GameObject cube;
    int correctWords;

    public GameObject scorePanel;
    public GameObject buttonPanel;
    public Text text;
    public void Showscore()
    {
        score = button_1.GetComponent<AddWords>().score + button_2.GetComponent<AddWords>().score + button_3.GetComponent<AddWords>().score + button_4.GetComponent<AddWords>().score + button_5.GetComponent<AddWords>().score + button_6.GetComponent<AddWords>().score + button_7.GetComponent<AddWords>().score + button_8.GetComponent<AddWords>().score + button_9.GetComponent<AddWords>().score + button_10.GetComponent<AddWords>().score;
        correctWords = cube.GetComponent<Memorymanager>().correctWOrdsCount;
        text.text = ((score* 100/correctWords)).ToString();
        Debug.Log("score" + score);
        Debug.Log("correctWords" + correctWords);
        Debug.Log("score to be" + score * 100 / correctWords);
        scorePanel.SetActive(true);
        buttonPanel.SetActive(false);
    }
}
