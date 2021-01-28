using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillColliders : MonoBehaviour
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
        
        if (other.gameObject.tag.StartsWith("Water"))       
        {
            log += "Collider hit by Water";
            this.gameObject.SetActive(false);
        }
    }
    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
