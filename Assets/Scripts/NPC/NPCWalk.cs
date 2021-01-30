using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCWalk : MonoBehaviour
{
    public GameObject target;
    public GameObject NPCCanvas;
    public GameObject Townhall;
    public float speedMod = 1f;
    private Vector3 point;
    private Vector3 lastPosition;
    private Vector3 testVecor;
    private NavMeshAgent navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveAgent();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPCGoal1"))
        {
            NPCCanvas.SetActive(true);

            if (Globals.timeOver)
            {
                target = Townhall;
            }
        }
    }

    private void MoveAgent()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}
