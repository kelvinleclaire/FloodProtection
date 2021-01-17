using UnityEngine;
using System.Timers;

public class StartTheGame : MonoBehaviour
{
    public GameObject startCanvas;
    private float timeRemaining = 10;
    private static Timer aTimer;

    // Start is called before the first frame update
    void Start()
    {
        aTimer = new Timer();
        aTimer.Interval = 1000;
        aTimer.Elapsed += ATimer_Elapsed;
    }

    private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        timeRemaining -= 1;
        Globals.timer = timeRemaining;
        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void Begin()
    {
        if (startCanvas != null)
        {
            startCanvas.SetActive(false);
            aTimer.Enabled = true;
        }

    }
}
