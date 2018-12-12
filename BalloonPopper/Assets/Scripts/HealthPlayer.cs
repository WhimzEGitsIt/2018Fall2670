using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;


public class HealthPlayer : MonoBehaviour
{
	 
	
	public Store store;

	public List<Transform> positions;  
	
	public int curHealth;

	public int maxHealth = 3;

	void Start()
	{
		GameObject.FindObjectOfType<ScoreScript>().Cash.Value = 0;
		curHealth = maxHealth;
	}

	void Update()
	{
		if (curHealth > maxHealth)
		{
			curHealth = maxHealth;
		}

		if (curHealth <=0)
		{
			Die();
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Falling Balloon")
		{
			curHealth--;
		}
	}
	
	void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void UseUmbrella()
	{
		if (store.Purchased.Count == 0)
		{
			return;
		}

		
		store.Purchased.RemoveAt(0);
		int i = Random.Range(0, 3);
		Transform t = positions[i];
		GameObject.Instantiate((GameObject)store.Item, t);
	}
}
