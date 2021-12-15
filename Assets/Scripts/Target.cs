using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.destination = target.position;
    }
}
