using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public GameObject target;
    public GameObject NPCCanvas;
    public GameObject Townhall;
    public float speedMod = 10.0f;
    private Vector3 point;
    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        point = target.transform.position;
        lastPosition = target.transform.position;
        transform.LookAt(point);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (lastPosition != target.transform.position)
        {
            transform.position -= (lastPosition - target.transform.position);
            lastPosition = target.transform.position;
            point = lastPosition;
        }

        transform.RotateAround(point, new Vector3(0.0f, 1f, 0f), horizontal * Time.deltaTime * speedMod);
        transform.LookAt(point);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPCGoal1"))
        {
            NPCCanvas.SetActive(true);

            if (Globals.timeOver) { 
            target = Townhall;
            }
        }
    }
}
