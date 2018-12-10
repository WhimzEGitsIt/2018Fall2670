using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{

	public int curHealth;

	public int maxHealth = 3;

	void Start()
	{
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


}
