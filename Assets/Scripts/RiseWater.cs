using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;



public class RiseWater : MonoBehaviour
{
    public GameObject waterLeft;
    public GameObject waterRight;
    private Vector3 vector1;
    private Vector3 vector2;
    public float timeRemaining = 3;
    private static Timer aTimer;
    private bool stopWater;
    // Start is called before the first frame update
    void Start()
    {
        vector1 = waterLeft.transform.localScale;
        vector2 = waterRight.transform.localScale;
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
                waterLeft.transform.localScale = vector2;
                waterRight.transform.localScale = vector1;
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


        if (Globals.dropzoneRight)
        {

            //If hit y= 0.3
            vector1 += new Vector3(0f, 0.1f, 0f);
        }
        if (!Globals.dropzoneRight)
        {
            // if no Sandsack y= ~0.5
            vector1 += new Vector3(0f, 0.166f, 0f);
        }

        if (Globals.dropzoneLeft)
        {

            //If hit y= 0.3
            vector2 += new Vector3(0f, 0.1f, 0f);
        }
        if (!Globals.dropzoneLeft)
        {
            // if no Sandsack y= ~0.5
            vector2 += new Vector3(0f, 0.166f, 0f);
        }



        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = false;
            stopWater = true;
        }

    }
}
