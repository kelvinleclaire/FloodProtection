﻿using UnityEngine;
using System.Timers;


public class WaterScript : MonoBehaviour
{
    public GameObject Water;
    private Vector3 vector;
    private float y;
    private float timeRemaining = 6000;
    private Timer aTimer;

    public GUIStyle style = new GUIStyle();
    string log = "";

    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 50;

        vector = Water.transform.localScale;

        if (Water.CompareTag("Water"))
        {
            this.y = 0.001f;
            log += "\n Sind in Water \n";

        }
        if (Water.tag.StartsWith("Side"))
        {
            this.y = 0f;
            log += "\n Sind in Side \n";

        }

        aTimer = new Timer();
        aTimer.Interval = 100;
        aTimer.Elapsed += this.ATimer_Elapsed;
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
                Water.transform.localScale = vector;
            }
        }
    }

    private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
    {

        vector += new Vector3(0f, this.y, 0f);

        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = false;
        }
        timeRemaining -= 1;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag.StartsWith("Side") && other.gameObject.CompareTag("Water"))
        {
            y = 0.001f;
        }

        if (other.gameObject.tag.StartsWith("Sandsack"))
        {
            vector.y = other.gameObject.transform.localPosition.y;
            y = 0f;
        }
    }
    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
