using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;


public class HealthPlayer : MonoBehaviour
{
	 
	
	public Store store;

	public List<GrandmaPositions> positions;  
	
	public int curHealth;

	public int maxHealth = 3;

	void Start()
	{
		Random.InitState(Mathf.RoundToInt(Time.realtimeSinceStartup));
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
		int i;
		do
		{
			i = Random.Range(0, 4);
		} while (positions[i].inuse);
		
		Transform t = positions[i].position;
		GameObject.Instantiate((GameObject)store.Item, t.position, t.rotation);
		positions[i] = new GrandmaPositions(positions[i].position, true);
	}

	
	
}


[Serializable]
public struct GrandmaPositions
{
	public Transform position;
	public bool inuse;

	public GrandmaPositions(Transform t, bool b)
	{
		position = t;
		inuse = b;
	}
}
