using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public Transform[] spawnPoints;

	public GameObject balloonPrefab;

	public float timeBetweenSpawn = 1f;
	
	private float timetoSpawn = 2f;

	
	// Use this for initialization
	void Update ()
	{

		if (Time.time >= timetoSpawn)
		{
			SpawnBlocks();
			timetoSpawn = Time.time + timeBetweenSpawn;
		}
		
		
		
	}

	void SpawnBlocks()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex == i)
			{
				Instantiate(balloonPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
	
	
}
