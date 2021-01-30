using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActuallyStartTheGame : MonoBehaviour
{
    public GameObject Welcome;

    public void StartTheGame()
    {
        if (Welcome != null)
        {
            Globals.timeOver = true;
            Welcome.SetActive(false);            
        }

    }
}
