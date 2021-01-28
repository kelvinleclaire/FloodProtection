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
    public GameObject SideWater11;
    public GameObject SideWater12;
    public GameObject SideWater13;
    public GameObject SideWater21;
    public GameObject SideWater22;
    public GameObject SideWater23;
    private Vector3 vector1;
    private Vector3 vector2;
    private Vector3 vector3;
    private Vector3 vector4;
    private Vector3 vector5;
    private Vector3 vector6;
    private Vector3 sideVector11;
    private Vector3 sideVector12;
    private Vector3 sideVector13;
    private Vector3 sideVector21;
    private Vector3 sideVector22;
    private Vector3 sideVector23;
    private float y1 = 0.01f;
    private float y2 = 0.01f;
    private float y3 = 0.01f;
    private float y4 = 0.01f;
    private float y5 = 0.01f;
    private float y6 = 0.01f;
    private float y11 = 0f;
    private float y12 = 0f;
    private float y13 = 0f;
    private float y21 = 0f;
    private float y22 = 0f;
    private float y23 = 0f;
    public float timeRemaining = 60;
    private static Timer aTimer;
    private bool stopWater;
    // Start is called before the first frame update
    void Start()
    {
        vector1 = Water1.transform.localScale;
        vector2 = Water2.transform.localScale;
        vector3 = Water3.transform.localScale;
        vector4 = Water4.transform.localScale;
        vector5 = Water5.transform.localScale;
        vector6 = Water6.transform.localScale;
        sideVector11 = SideWater11.transform.localScale;
        sideVector12 = SideWater11.transform.localScale;
        sideVector13 = SideWater11.transform.localScale;
        sideVector21 = SideWater11.transform.localScale;
        sideVector22 = SideWater11.transform.localScale;
        sideVector23 = SideWater11.transform.localScale;

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
                SideWater11.transform.localScale = sideVector11;
                SideWater12.transform.localScale = sideVector12;
                SideWater13.transform.localScale = sideVector13;
                SideWater21.transform.localScale = sideVector21;
                SideWater22.transform.localScale = sideVector22;
                SideWater23.transform.localScale = sideVector23;
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
        if (Globals.waterHitSandsack1) { y1 = 0; }
        if (Globals.waterHitSandsack2) { y2 = 0; }
        if (Globals.waterHitSandsack3) { y3 = 0; }
        if (Globals.waterHitSandsack4) { y4 = 0; }
        if (Globals.waterHitSandsack5) { y5 = 0; }
        if (Globals.waterHitSandsack6) { y6 = 0; }

        vector1 += new Vector3(0f, y1, 0f);
        vector2 += new Vector3(0f, y2, 0f);
        vector3 += new Vector3(0f, y3, 0f);
        vector4 += new Vector3(0f, y4, 0f);
        vector5 += new Vector3(0f, y5, 0f);
        vector6 += new Vector3(0f, y6, 0f);
        sideVector11 += new Vector3(0f, y11, 0f);
        sideVector12 += new Vector3(0f, y12, 0f);
        sideVector13 += new Vector3(0f, y13, 0f);
        sideVector21 += new Vector3(0f, y21, 0f);
        sideVector22 += new Vector3(0f, y22, 0f);
        sideVector23 += new Vector3(0f, y23, 0f);




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
