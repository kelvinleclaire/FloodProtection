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
        //Sobald das der Timer abgelaufen ist, wird das Spiel ausgewertet und das entsprechende Ende eingeblendet.
        if (Globals.endGame) {

            switch (Globals.state)
            {
                case StateEnum.Win:
                    VictoryScreen.SetActive(true);
                    break;
                case StateEnum.HaflWin:
                    HalfWonScreen.SetActive(true);
                    break;
                case StateEnum.Lose:
                    LoseScreen.SetActive(true);
                    break;
            }      
        }

    }

   
}
