using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;



public class RiseWater : MonoBehaviour
{
    public GUIStyle style = new GUIStyle();
    string log = "";
    public GameObject Water1;
    public GameObject Water2;
    public GameObject Water3;
    public GameObject Water4;
    public GameObject Water5;
    public GameObject Water6;
    private Vector3 vector1;
    private Vector3 vector2;
    private Vector3 vector3;
    private Vector3 vector4;
    private Vector3 vector5;
    private Vector3 vector6;
    private float y1 = 0.1f;
    private float y2 = 0.1f;
    private float y3 = 0.1f;
    private float y4 = 0.1f;
    private float y5 = 0.1f;
    private float y6 = 0.1f;
    public float timeRemaining = 60;
    private static Timer aTimer;
    private bool stopWater;
    // Start is called before the first frame update
    void Start()
    {
        vector1 = Water1.transform.localScale;
        vector2 = Water2.transform.localScale;
        vector2 = Water3.transform.localScale;
        vector2 = Water4.transform.localScale;
        vector2 = Water5.transform.localScale;
        vector2 = Water6.transform.localScale;

        aTimer = new Timer();
        aTimer.Interval = 1000;
        aTimer.Elapsed += ATimer_Elapsed;
        stopWater = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.timeOver)
        {
            if (!aTimer.Enabled)
            {
                aTimer.Enabled = true;
            }
            else
            {
            //    waterLeft.transform.localScale = vector2;
            //    waterRight.transform.localScale = vector1;
            
            Water1.transform.localScale = vector1;
            Water2.transform.localScale = vector2;
            Water3.transform.localScale = vector3;
            Water4.transform.localScale = vector4;
            Water5.transform.localScale = vector5;
            Water6.transform.localScale = vector6;
            }
        }

        if (stopWater)
        {
            SceneManager.LoadScene("Endscreen");
        }
    }

    private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
    {

        timeRemaining -= 1;
        if (vector5.y >= 0.415f) { y5 = 0; }
        if (vector2.y >= 0.415f) { y2 = 0; log += "y2 = 0\n"; }

        vector1 += new Vector3(0f, y1, 0f);
        vector2 += new Vector3(0f, y2, 0f);
        vector3 += new Vector3(0f, y3, 0f);
        vector4 += new Vector3(0f, y4, 0f);
        vector5 += new Vector3(0f, y5, 0f);
        vector6 += new Vector3(0f, y6, 0f);
        


        //if (Globals.dropzoneRight)
        //{

        //    //If hit y= 0.3
        //    vector1 += new Vector3(0f, 0.1f, 0f);
        //}
        //if (!Globals.dropzoneRight)
        //{
        //    // if no Sandsack y= ~0.5
        //    vector1 += new Vector3(0f, 0.166f, 0f);
        //}

        //if (Globals.dropzoneLeft)
        //{

        //    //If hit y= 0.3
        //    vector2 += new Vector3(0f, 0.1f, 0f);
        //}
        //if (!Globals.dropzoneLeft)
        //{
        //    // if no Sandsack y= ~0.5
        //    vector2 += new Vector3(0f, 0.166f, 0f);
        //}



        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = false;
            //stopWater = true;
        }

    }

    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
