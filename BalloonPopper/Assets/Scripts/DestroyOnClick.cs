using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{

	private ScoreScript score;
	
	
	void Start()
	{
		score = GameObject.FindObjectOfType<ScoreScript>();
	}
	
	
	
	void OnMouseDown()
	{
		SoundManager.PlaySound("waterDrop");
		score.Cash.Value += 10;
		Destroy(gameObject);
	}
	
}
