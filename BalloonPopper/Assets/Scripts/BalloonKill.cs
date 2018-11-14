using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class BalloonKill : MonoBehaviour {

	
	//void Update () {

		//if (transform.position.y < -4f)
		//{
			//Destroy(gameObject);
		//}

	//}

	void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
	}
}
