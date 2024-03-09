using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    

    NavMeshAgent navMeshAgent;
    float distanceToTaget = Mathf.Infinity;
    bool isFroboked = false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToTaget = Vector3.Distance(target.position, transform.position);
        if(isFroboked)
        {
            EngageTarget();
        }
        else if(distanceToTaget <= chaseRange)
        {
            isFroboked = true;
        }
    }

    void EngageTarget()
    {
        if(distanceToTaget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        if(distanceToTaget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    void ChaseTarget()
    {
        navMeshAgent.SetDestination(target.position);
    }

    void AttackTarget()
    {
        Debug.Log("you attacked jombie");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    
}
