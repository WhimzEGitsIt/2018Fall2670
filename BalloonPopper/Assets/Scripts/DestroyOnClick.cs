using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour {

	void OnMouseDown()
	{
		SoundManager.PlaySound("waterDrop");
		ScoreScript.scoreValue += 10;
		Destroy(gameObject);
	}
	
}
