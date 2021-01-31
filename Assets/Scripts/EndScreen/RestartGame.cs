using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    //Die Werte des Singleton werden resettet und die Szene wird neu geladen
    public void Restart()
    {
        Globals.Init();
        SceneManager.LoadScene("MainScene");
    }
}
