using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public GameObject TimerCanvas;
    public GameObject TimerText;
    private Text myText;
    public GUIStyle style = new GUIStyle();
    string log = "";


    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("TimerText").GetComponent<Text>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (myText)
        {
            myText.text = $"TIMER: {Globals.timer}";
        }
        //log += myText.text + "\n";

    }

    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }

}
