using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Objects", menuName = "Store/Objects")]
public class Objects : ScriptableObject, IEnumerable
{
	public List<Object> ObjectList;
	public IEnumerator GetEnumerator()
	{
		throw new System.NotImplementedException();
	}
}
