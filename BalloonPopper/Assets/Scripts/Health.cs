using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

	public int health;
	public int numOfhearts;

	public Image[] hearts;
	public Sprite fullHeart;
	public Sprite emptyHeart;

	public void TakeHealth()
	{
		if (health > numOfhearts)
		{
			health = numOfhearts;
		}
		
		
		for (int i = 0; i < hearts.Length; i++)
		{
			if (i < health)
			{
				hearts[i].sprite = fullHeart;
			}
			else
			{
				hearts[i].sprite = emptyHeart;
			}
			
			
			if (i < numOfhearts)
			{
				hearts[i].enabled = true;
			}
			else
			{
				hearts[i].enabled = false;
			}
		}
	}

	public void HurtPlayer(int damageToTake)
	{
		health -= damageToTake;
	}
}
