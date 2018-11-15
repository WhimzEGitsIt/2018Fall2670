using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

	public static AudioClip waterDrop, punch, woosh;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start ()
	{

		waterDrop = Resources.Load<AudioClip>("waterDrop");
		punch = Resources.Load<AudioClip>("punch");
		woosh = Resources.Load<AudioClip>("woosh");

		audioSrc = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string clip)
	{
		switch (clip)
		{
			case "waterDrop":
				audioSrc.PlayOneShot(waterDrop);
				break;
			case "punch":
				audioSrc.PlayOneShot(punch);
				break;
			case "woosh":
				audioSrc.PlayOneShot(woosh);
				break;
			
		}
	}
	
}
