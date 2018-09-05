using UnityEngine;

[CreateAssetMenu(fileName = "New Float", menuName = "CG/floatdata")]

public class FloatData : ScriptableObject
{

	public float value;
	
	public virtual float Value
	{
		get { return value;}
	}

}
