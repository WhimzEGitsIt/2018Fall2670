using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrandmaScript : MonoBehaviour
{

	public int health;
	public Sprite[] picture;
	private int count = 0;
	

	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Falling Balloon")
		{
			health--;
		}

		if (health <=0)
		{
			print("GameOver");
		}

		GetComponent<SpriteRenderer>().sprite = picture[count];
	}
}
