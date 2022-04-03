using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
        if (enemy.remainingDistance<4f)
        {
            enemy.isStopped = true;
            
        } else{
            enemy.isStopped = false;

        }
    }
}