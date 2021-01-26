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


    // Start is called before the first frame update
    void Awake()
    {
        log += "Awaken yo \n";


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                log += "Touch erkannt \n";
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                //Falls noch kein GO selected wurde

                if (string.IsNullOrEmpty(selected))
                {
                    if (Physics.Raycast(ray, out hit))
                    {
                        log += "Inside Raycast \n";

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
                //Falls bereits ein GO selected ist und nun drapiert werden soll
                else
                {
                    if (Physics.Raycast(ray, out hit))
                    {
                        GameObject go2 = GameObject.FindWithTag(selected);
                        if (go2 != null)
                        {
                            if (hit.collider.tag.StartsWith("Dropzone"))
                            {
                                //go2.transform.localPosition = hit.transform.position;
                                //go2.transform.localPosition = new Vector3(hit.transform.position.x, 1f, hit.transform.position.y);
                                if (hit.collider.tag == "Dropzone")
                                {
                                    log += $"Position: {go2.transform.position}";
                                    Globals.sandsackPosition = go2.transform.position;
                                    log += $"Local Position: {go2.transform.localPosition}";
                                    go2.transform.localPosition = new Vector3(1.16f, 1f, 1.98f);
                                    selected = "";
                                    Globals.dropzoneRight = true;
                                }
                                if (hit.collider.tag == "Dropzone2")
                                {
                                    go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                    selected = "";
                                    Globals.dropzoneLeft = true;
                                }

                                switch (hit.collider.tag)
                                {
                                    case "Dropzone1.1":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone1.2":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone1.3":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone1.4":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                //Zweite Reihe der Dropzones
                                    case "Dropzone2.1":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone2.2":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone2.3":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone2.4":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone2.5":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                //Dritte Reihe der Dropzones
                                    case "Dropzone3.1":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone3.2":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone3.3":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
                                        selected = "";
                                        break;
                                    case "Dropzone3.4":
                                        go2.transform.localPosition = new Vector3(1.43f, 1f, -1.95f);
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
                //go.transform.GetComponent<Renderer>().material.SetTexture("SelectedSandsack", texture);
            }
        }
    }



    void ChangeSelectedOject(GameObject selected)
    {
        log += "Hier kommen wir nie an" + "\n";
    }

    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }

}
