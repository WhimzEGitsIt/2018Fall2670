using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class BalloonKill : MonoBehaviour
{

	public int damageToTake;

	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Grandma")
		{
			triggerCollider.gameObject.GetComponent<Health>().HurtPlayer(damageToTake);
			SoundManager.PlaySound("punch");
			Destroy(gameObject);
		}
		
	}
}
