using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class BalloonKill : MonoBehaviour {

	
	void Update () {

		if (transform.position.y < - 2.5f)
		{
			Destroy(gameObject);
		}

	}

}
