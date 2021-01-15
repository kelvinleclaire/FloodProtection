using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class CreateReferencePoint : MonoBehaviour
{
    ARReferencePointManager arReferencePointManager;

    public GUIStyle style = new GUIStyle();

    string log = "";

    // Start is called before the first frame update
    void Awake()
    {
        GameObject go = GameObject.Find("AR Session Origin");
        arReferencePointManager = go.GetComponent<ARReferencePointManager>();
        if(arReferencePointManager != null)
        {
            log += "ARReferencePointManager sucessfull set\n";
        }else
        {
            log += "could not get ARReferencePointManager";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetReferencePointAsParent(ARPlacementInteractable arPlacementInteractable, GameObject gameObject)
    {
        log += "A new Object has been placed\n";

        Vector3 position = gameObject.transform.position;
        Quaternion quaternion = gameObject.transform.rotation;
        Pose hitPose = new Pose(position, quaternion);

        ARReferencePoint arReferencePoint = arReferencePointManager.AddReferencePoint(hitPose);

        if (arReferencePoint == null)
        {
            log += "Could not get ARReferencePoint\n";
        }else
        {
            gameObject.transform.SetParent(arReferencePoint.transform);
            log += "ARReferencePoint has been set as parent\n";
        }
    }

    private void OnGUI()
        {
            GUILayout.Label(log, style);
        }
}
