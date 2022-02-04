using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class brain : MonoBehaviour
{
    
    public NavMeshAgent navMeshAgent;
    public GameObject destino1;
    public GameObject destino2;

    void Start()
    {
        navMeshAgent.destination = destino1.transform.position;

    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, destino1.transform.position);

        if (distance < 2)
        {
            navMeshAgent.destination = destino2.transform.position;
        }
    }
}
