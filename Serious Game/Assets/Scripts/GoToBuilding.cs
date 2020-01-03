using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBuilding : MonoBehaviour
{
    public GameObject button;
    public GameObject text;

    public void Building()
    {
        if (button.name == "Button Metaforum")
        {
            Debug.Log("Metaforum");
            SceneManager.LoadScene("Metaforum");
        }

        if (button.name == "Button Atlas")
        {
            Debug.Log("Atlas");
            SceneManager.LoadScene("Atlas");
        }

        if (button.name == "Button Luna")
        {
            Debug.Log("Luna");
            text.SetActive(true);
        }

        if (button.name == "Button Helix")
        {
            Debug.Log("Helix");
            text.SetActive(true);
        }

        if (button.name == "Button Aurora")
        {
            Debug.Log("Aurora");
            text.SetActive(true);
        }

        if (button.name == "Button LaPlace")
        {
            Debug.Log("LaPlace");
            text.SetActive(true);
        }

        if (button.name == "Button Gemini South")
        {
            Debug.Log("Gemini South");
            text.SetActive(true);
        }

        if (button.name == "Button Gemini North")
        {
            Debug.Log("Gemini North");
            text.SetActive(true);
        }

        if (button.name == "Button Flux")
        {
            Debug.Log("Flux");
            text.SetActive(true);
        }

        if (button.name == "Button Traverse")
        {
            Debug.Log("Traverse");
            text.SetActive(true);
        }

        if (button.name == "Button Sport Centrum")
        {
            Debug.Log("Sport Centrum");
            text.SetActive(true);
        }

        if (button.name == "Button Auditorium")
        {
            Debug.Log("Auditorium");
            text.SetActive(true);
        }
    }


}
