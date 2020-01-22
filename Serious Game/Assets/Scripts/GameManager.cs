using UnityEngine;
using UnityEngine.UI;   

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject wrongUI;
    public GameObject correctUI;
    public GameObject stroopWords;
    public Color color;
    public string text;
    int randomC;
    int randomT;
    int random;

    public GameObject correctChoice;
    public GameObject wrongChoice;
    public GameObject player;
    public Vector3 playerposition;
    public Vector3 correctposition;
    public Vector3 wrongposition;

    Color[] colors = { new Color(0, 0, 255), new Color(255, 0, 0), new Color(255, 255, 0), new Color(255, 0, 255), new Color(34, 139, 34) };
    string[] colorsText = { "BLUE", "RED", "YELLOW", "PURPLE", "GREEN"};

    public GameObject scoreCanvas;
    public int scoreCounter = 5;
    int counter = 0;

    public void StroopTest()
    {
        randomC = Random.Range(0, 4);
        randomT = Random.Range(0, 4);
        while (randomC == randomT)
        {
            randomT = Random.Range(0, 4);
        }
        color = colors[randomC];
        text = (colorsText[randomT]);

        Text stroopWord = stroopWords.GetComponentInChildren(typeof(Text)) as Text;
        stroopWord.text = text.ToString();
        stroopWord.color = color;

        correctUI.SetActive(false);
        wrongUI.SetActive(false);
        canvas.SetActive(false);
        stroopWords.SetActive(true);

        correctChoice.GetComponent<ColorChange>().ChangeColor(color);
        wrongChoice.GetComponent<ColorChange>().ChangeColor(colors[randomT]);

        player.transform.position = playerposition;
        random = Random.Range(0, 2);
        if(random == 0)
        {
            correctChoice.transform.position = correctposition;
            wrongChoice.transform.position = wrongposition;
        }
        else
        {
            correctChoice.transform.position = wrongposition;
            wrongChoice.transform.position = correctposition;
        }

        counter += 1;

        if (counter == 6)
        {
            canvas.SetActive(false);
            wrongUI.SetActive(false);
            correctUI.SetActive(false);
            stroopWords.SetActive(false);

            Text text = scoreCanvas.GetComponentInChildren(typeof(Text)) as Text;
            text.text = scoreCounter.ToString();

            scoreCanvas.SetActive(true);
        }
       
    }
}
