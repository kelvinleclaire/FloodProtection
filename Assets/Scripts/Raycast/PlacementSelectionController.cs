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
    private string selected = "";

    public Camera arCamera;

    private Vector2 touchPosition = default;

    public Transform _myGameObject;

    public Texture texture;

    private float yPos = 0.03f;
    public GameObject Plane;


    // Start is called before the first frame update
    void Start()
    {
        log += "Awaken \n";
    }

    // Update is called once per frame
    void Update()
    {
        if (Plane == null)
        {
            Plane = GameObject.Find("Plane");
            if (Plane != null)
            {                
                log += $"yPos= {yPos}\n";
            }
        }
        else
        {
            //Ein Touch auf dem Screen wird erkannt.
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                touchPosition = touch.position;
                if (touch.phase == TouchPhase.Began)
                {
                    log += "Touch erkannt \n";
                    Ray ray = arCamera.ScreenPointToRay(touch.position);
                    RaycastHit hit;

                    //Falls noch kein GameObject selected wurde
                    if (string.IsNullOrEmpty(selected))
                    {
                        //In "hit" befindet sich das getroffene Object
                        if (Physics.Raycast(ray, out hit))
                        {
                            log += "Inside Raycast \n";
                            //Falls ein Sandsack berührt wurde, wird dessen Tag gespeichert
                            if (hit.collider.tag.StartsWith("Sandsack"))
                            {
                                selected = hit.collider.tag;
                            }

                            //Auswahl der Telefonzelle
                            if (hit.collider.tag == "Cellphone")
                            {
                                Globals.orderScreen = true;
                            }
                            log += $"selected: {selected}\n";
                        }
                    }
                    //Falls bereits ein GameObject selected ist soll dieses nun drapiert werden
                    else
                    {
                        if (Physics.Raycast(ray, out hit))
                        {
                            //Übergabe des zuvor selektierten Sandsacks
                            GameObject go2 = GameObject.FindWithTag(selected);
                            if (go2 != null)
                            {
                                //Platzierung nur auf Dropzone möglich
                                if (hit.collider.tag.StartsWith("Dropzone"))
                                {
                                    //Abfrage wo der Sandsack hingesetzt wird
                                    switch (hit.collider.tag)
                                    {
                                        case "Dropzone1.1":
                                            go2.transform.localPosition = new Vector3(2f, yPos, 1.93f);
                                            selected = "";
                                            break;
                                        case "Dropzone1.2":
                                            go2.transform.localPosition = new Vector3(2f, yPos, -1.95f);
                                            selected = "";
                                            break;
                                        case "Dropzone1.3":
                                            go2.transform.localPosition = new Vector3(2f, yPos, -10f);
                                            selected = "";
                                            break;
                                        case "Dropzone1.4":
                                            go2.transform.localPosition = new Vector3(2f, yPos, 9.5f);
                                            selected = "";
                                            break;
                                        //Zweite Reihe der Dropzones
                                        case "Dropzone2.1":
                                            go2.transform.localPosition = new Vector3(-3f, yPos, 9.5f);
                                            selected = "";
                                            break;
                                        case "Dropzone2.2":
                                            go2.transform.localPosition = new Vector3(-3f, yPos, 1.93f);
                                            selected = "";
                                            break;
                                        case "Dropzone2.3":
                                            go2.transform.localPosition = new Vector3(-1.43f, yPos, -2.41f);
                                            selected = "";
                                            break;
                                        case "Dropzone2.4":
                                            go2.transform.localPosition = new Vector3(-3f, yPos, -6.1f);
                                            selected = "";
                                            break;
                                        case "Dropzone2.5":
                                            go2.transform.localPosition = new Vector3(-2.4f, yPos, -10f);
                                            selected = "";
                                            break;
                                        //Dritte Reihe der Dropzones
                                        case "Dropzone3.1":
                                            go2.transform.localPosition = new Vector3(-8f, yPos, -10f);
                                            selected = "";
                                            break;
                                        case "Dropzone3.2":
                                            go2.transform.localPosition = new Vector3(-8f, yPos, -6.1f);
                                            selected = "";
                                            break;
                                        case "Dropzone3.3":
                                            go2.transform.localPosition = new Vector3(-8f, yPos, 1.93f);
                                            selected = "";
                                            break;
                                        case "Dropzone3.4":
                                            go2.transform.localPosition = new Vector3(-8f, yPos, 9.5f);
                                            selected = "";
                                            break;
                                    }
                                }
                            }
                        }
                    }

                    //Farbe ändern
                    GameObject go = GameObject.FindWithTag(selected);
                    Renderer goRenderer = go.GetComponent<Renderer>();
                    goRenderer.material.SetColor("_Color", Color.red);
                    if (go.tag != selected)
                    {
                        goRenderer.material.SetColor("_Color", Color.yellow);
                    }
                }
            }
        }
    }

    private void OnGUI()
    {
        //GUILayout.Label(log, style);
    }

}
