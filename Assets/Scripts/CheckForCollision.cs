using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollision : MonoBehaviour
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


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sandsack")){
            log +="Sandsack Colision \n";
        }
        else
            log += "Colision erkannt! \n";
    }

    private void OnGUI()
        {
            GUILayout.Label(log, style);
        }
}
