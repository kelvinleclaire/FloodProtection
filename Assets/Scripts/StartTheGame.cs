using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject WelcomeCanvas;

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
            WelcomeCanvas.SetActive(true);
            startCanvas.SetActive(false);          
        }

    }
}
