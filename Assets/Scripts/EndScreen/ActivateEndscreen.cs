using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEndscreen : MonoBehaviour
{
    public GameObject LoseScreen;
    public GameObject VictoryScreen;
    public GameObject HalfWonScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.endGame) { 
        if (Globals.check80 && !Globals.check40 && !Globals.check10)
        {
            VictoryScreen.SetActive(true);
        }
        if (Globals.check40 && !Globals.check10)
        {
            HalfWonScreen.SetActive(true);
        }
        if (Globals.check10)
            {
                LoseScreen.SetActive(true);
            }
        }

    }

   
}
