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
		health = GameObject.FindGameObjectWithTag("Grandma").GetComponent<HealthPlayer>();
	}

	void Update()
	{
		HeartUI.sprite = HeartSprites [health.curHealth];
	}
	


}
