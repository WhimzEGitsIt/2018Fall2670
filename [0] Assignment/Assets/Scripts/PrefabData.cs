using UnityEngine;

[CreateAssetMenu]
public class PrefabData : ScriptableObject
{

	public GameObject Prefab;
	public Sprite SpriteImage;
	public Color SpriteColor;

	public void OnConfiger()
	{
		var newPrefab = Instantiate(Prefab);
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
		newSprite.sprite = SpriteImage;
		newSprite.color = SpriteColor;
	}

}
