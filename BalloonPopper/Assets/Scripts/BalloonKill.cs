﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class BalloonKill : MonoBehaviour
{



	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Grandma")
		{
			
			SoundManager.PlaySound("punch");
			Destroy(gameObject);
		}
		
		if (triggerCollider.tag == "Umbrella")
		{
			HealthPlayer hp = FindObjectOfType<HealthPlayer>();
			Debug.Log("cp1");
			int i = hp.positions.FindIndex(gp => gp.position.position.Equals(triggerCollider.gameObject.transform.position));
			Debug.Log(i);
			hp.positions[i] = new GrandmaPositions(hp.positions[i].position, false);
			Debug.Log("cp2");
			Destroy(triggerCollider.gameObject);
			Destroy(gameObject);
		}
	}
	
	
}
