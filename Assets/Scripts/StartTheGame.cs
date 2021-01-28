using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public GameObject startCanvas;

    // Start is called before the first frame update
    void Start()
    {

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
            Globals.timeOver = true;
        }

    }
}
