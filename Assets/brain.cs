using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class brain : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject destino1;

    void Start()
    {
        navMeshAgent.destination = destino1.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
