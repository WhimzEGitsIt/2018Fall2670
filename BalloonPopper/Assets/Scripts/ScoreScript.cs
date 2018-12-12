using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{

	public IntData Cash;
	
	Text score;
	
	
	
	void Start ()
	{
		score = GetComponent<Text>();
	}
	
	void Update ()
	{
		score.text = "Score: " + Cash.Value;
	}
}
