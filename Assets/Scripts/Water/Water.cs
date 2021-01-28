using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;


public class WaterScript : MonoBehaviour
{
    public GameObject Water;
    private Vector3 vector;
    private float y;
    private float timeNow;
    public float timeRemaining = 60;
    private static Timer aTimer;

    // Start is called before the first frame update
    void Start()
    {
        vector = Water.transform.localScale;

        aTimer = new Timer();
        aTimer.Interval = 10;
        aTimer.Elapsed += ATimer_Elapsed;
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
        vector += new Vector3(0f, y, 0f);

        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = false;
        }
    }
}
