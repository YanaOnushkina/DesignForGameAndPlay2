using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBuilding : MonoBehaviour
{
    public GameObject button;

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
        }

        if (button.name == "Button Helix")
        {
            Debug.Log("Helix");
        }

        if (button.name == "Button Aurora")
        {
            Debug.Log("Aurora");
        }

        if (button.name == "Button LaPlace")
        {
            Debug.Log("LaPlace");
        }

        if (button.name == "Button Gemini South")
        {
            Debug.Log("Gemini South");
        }

        if (button.name == "Button Gemini North")
        {
            Debug.Log("Gemini North");
        }

        if (button.name == "Button Flux")
        {
            Debug.Log("Flux");
        }

        if (button.name == "Button Traverse")
        {
            Debug.Log("Traverse");
        }

        if (button.name == "Button Sport Centrum")
        {
            Debug.Log("Sport Centrum");
        }

        if (button.name == "Button Auditorium")
        {
            Debug.Log("Auditorium");
        }
    }


}
