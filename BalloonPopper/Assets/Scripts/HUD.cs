using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

	public Sprite[] HeartSprites;

	public Image HeartUI;

	private HealthPlayer health;

	void Start()
	{
		health = GameObject.FindObjectOfType<HealthPlayer>();
		//GameObject h = GameObject.FindGameObjectWithTag("Grandma");
		
		//Debug.Log(h.name);
		//health = h.GetComponent<HealthPlayer>();
		Debug.Log("Health: " + health.maxHealth) ;
	}

	void Update()
	{
		Debug.Log(health.curHealth);
		HeartUI.sprite = HeartSprites [health.maxHealth - health.curHealth];
		
	}
	


}
