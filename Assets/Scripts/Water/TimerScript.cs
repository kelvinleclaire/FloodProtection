using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public GUIStyle style = new GUIStyle();
    string log = "";


    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }

}
