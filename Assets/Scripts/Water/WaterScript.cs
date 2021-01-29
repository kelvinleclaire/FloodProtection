using UnityEngine;
using System.Timers;


public class WaterScript : MonoBehaviour
{
    public GameObject Water;
    private Vector3 vector;
    private float y = 0.01f;
    public float timeRemaining = 60;
    private static Timer aTimer;

    public GUIStyle style = new GUIStyle();
    string log = "";

    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 50;

        vector = Water.transform.localScale;

        if (this.gameObject.CompareTag("Water"))
        {
            y = 0.001f;

        }
        //if (this.gameObject.tag.StartsWith("Side"))
        //{
        //    y = 0f;
        //}

        aTimer = new Timer();
        aTimer.Interval = 1000;
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
        log += "Y ist gerade anscheindend :" + y + "\n";
        if (timeRemaining <= 0)
        {
            aTimer.Enabled = false;
            Globals.timeOver = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag.StartsWith("Side") && other.gameObject.CompareTag("Water"))
        {
            y = 0.001f;
        }

        if (other.gameObject.tag.StartsWith("Sandsack"))
        {
            y = 0f;
        }
    }
    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
