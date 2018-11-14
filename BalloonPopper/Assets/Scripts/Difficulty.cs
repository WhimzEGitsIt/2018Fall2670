using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public static class Difficulty {

	static float secondsToMaxDifficutly = 60;

	public static float GetDifficultyPercent()
	{
		return Mathf.Clamp01(Time.time / secondsToMaxDifficutly);
	}
	
}
