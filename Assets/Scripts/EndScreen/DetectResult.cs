using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectResult : MonoBehaviour
{
    public GameObject checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            switch (this.gameObject.tag)
            {
                case "Check10":
                    Globals.check10 = true;
                    break;
                case "Check40":
                    Globals.check40 = true;
                    break;
                case "Check80":
                    Globals.check80 = true;
                    break;
            }
        }
    }
}
