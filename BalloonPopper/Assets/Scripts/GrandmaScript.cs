using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrandmaScript : MonoBehaviour
{

	public UnityEvent Event;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Falling Balloon")
		{
			Event.Invoke();
		}
	}
}
