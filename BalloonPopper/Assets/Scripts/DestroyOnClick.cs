using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour {

	void OnMouseDown()
	{
		Debug.Log("Something Clicked");
		Destroy(gameObject);
	}
	
}
