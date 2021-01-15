using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.AR;



public class PlacementSelectionController : MonoBehaviour
{
    public GUIStyle style = new GUIStyle();

    string log = "";

    public GameObject go;

    public Camera arCamera;

    private Vector2 touchPosition = default;

    public Transform _myGameObject;


    // Start is called before the first frame update
    void Awake()
    {
        ChangeSelectedOject(go);
        log += "Awaken yo \n";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;
            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;
                var fwd = transform.TransformDirection (Vector3.forward);



                // if (Physics.Raycast (transform.position, fwd, out hit) && hit.collider.tag == "City") {
                    if (Physics.Raycast (transform.position, fwd, out hit)){
                        foreach (Transform child in transform) {
                        if (child.CompareTag("Sandsack")) {log += "Sandsack geRayCästed Bitch \n";}
                        }
                    
                }
                // if(Physics.Raycast(ray, out hitObject))
                // {
                //     //FEHLER IS HIER!
                //     GameObject go = hitObject.transform.GetComponent<GameObject>();
                //     log += "Touch: " + go + "\n";
                //     if(go != null)
                //     {
                //         log += "PlacementObject: " + (go) + "\n";
                //         ChangeSelectedOject(go);
                //     }
                // }
            }
        }
    }

    void ChangeSelectedOject(GameObject selected) 
    {
        log += (go) + "\n";
    }

    private void OnGUI()
        {
            GUILayout.Label(log, style);
        }
}
