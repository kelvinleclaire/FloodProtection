using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject WelcomeCanvas;


    public void Begin()
    {
        if (startCanvas != null)
        {
            //Der Welcome-Bildschirm wird aktiviert
            WelcomeCanvas.SetActive(true);
            startCanvas.SetActive(false);          
        }

    }
}
