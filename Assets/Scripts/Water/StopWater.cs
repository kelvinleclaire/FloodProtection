using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWater : MonoBehaviour
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
        if(other.gameObject.tag.StartsWith("Sandsack"))
        {
            switch (this.gameObject.tag)
            {
                case "Water1":
                    Globals.waterHitSandsack1 = true;
                    break;
                case "Water2":
                    Globals.waterHitSandsack2 = true;
                    break;
                case "Water3":
                    Globals.waterHitSandsack3 = true;
                    break;
                case "Water4":
                    Globals.waterHitSandsack4 = true;
                    break;
                case "Water5":
                    Globals.waterHitSandsack5 = true;
                    break;
                case "Water6":
                    Globals.waterHitSandsack6 = true;
                    break;
            }


            
        }
        //if (other.gameObject.tag.StartsWith("Dropzone"))
        //{
        //    log += "Dropzone detected \n";
        //    switch (other.gameObject.tag)
        //    {
        //        case "Dropzone1.1":
        //            GameObject go3 = GameObject.FindWithTag("Dropzone1.1");
        //            go3.SetActive(false);
        //            log += "Dropzone1.1 got hit \n";
        //            break;
        //        case "Dropzone1.2":
        //            other.gameObject.SetActive(false);
        //            log += "Dropzone1.2 got hit \n";
        //            break;
        //        case "Dropzone1.3":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone1.4":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone2.1":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone2.2":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone2.3":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone2.4":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone2.5":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone3.1":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone3.2":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone3.3":
        //            other.gameObject.SetActive(false);
        //            break;
        //        case "Dropzone3.4":
        //            other.gameObject.SetActive(false);
        //            break;
        //    }
       // }
    }
    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
