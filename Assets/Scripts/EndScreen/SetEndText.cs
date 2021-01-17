using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetEndText : MonoBehaviour
{
    public GameObject EndScreennCanvas;
    public GameObject EndText;
    private Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("EndText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myText)
        {
            if (Globals.dropzoneLeft && Globals.dropzoneRight) { 
            myText.text = "Glückwunsch! Du hast gewonnen";
            }
            else
            {
                myText.text = "Du hast leider verloren...";
            }
        }
    }

    public void ReloadTheGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void OnDestroy()
    {
        Globals.dropzoneLeft = false;
        Globals.dropzoneRight = false;
    }
}
