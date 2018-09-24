using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent)
)]

public class AIAgent : MonoBehaviour
{
	public Transform Destination;
	public Transform PointPost;
	private Transform finalDestination;
	private NavMeshAgent agent;
	
	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		finalDestination = transform;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if(obj.transform == Destination)
		finalDestination = Destination;
	}

	private void OnTriggerExit(Collider other)
	{
		finalDestination = PointPost;
	}

	private void Update()
	{
			agent.destination = finalDestination.position;
	}
}
