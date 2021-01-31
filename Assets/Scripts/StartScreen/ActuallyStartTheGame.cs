using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Großes Sorry für die Benamsung, aber das Umbenennen von erstellten Scripten in Unity erschafft viele Probleme...
public class ActuallyStartTheGame : MonoBehaviour
{
    public GameObject Welcome;

    public void StartTheGame()
    {
        if (Welcome != null)
        {
            //Der Timer für das Wasser wird gestartet und das Spiel beginnt
            Globals.timeOver = true;
            Welcome.SetActive(false);            
        }

    }
}
