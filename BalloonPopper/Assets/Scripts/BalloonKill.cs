using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class BalloonKill : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Grandma")
		{
			SoundManager.PlaySound("punch");
			Destroy(gameObject);
		}
		
	}
}
