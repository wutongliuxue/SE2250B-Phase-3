using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GiantMovement : MonoBehaviour
{

    public GameObject theDestination;
    NavMeshAgent theAgent;

    // Start is called before the first frame update
    void Start()
    {
       theAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }
}
