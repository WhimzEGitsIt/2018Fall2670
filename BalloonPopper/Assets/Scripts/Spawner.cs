using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public Transform[] spawnPoints;

	public GameObject balloonPrefab;

	public Vector2 timeBetweenSpawnMinMax;
	
	private float timetoSpawn = 2f;

	
	// Use this for initialization
	public void Update ()
	{

		if (Time.time >= timetoSpawn)
		{
			SpawnBlocks();
			float timeBetweenSpawn = Mathf.Lerp(timeBetweenSpawnMinMax.y, timeBetweenSpawnMinMax.x, Difficulty.GetDifficultyPercent());
			
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
