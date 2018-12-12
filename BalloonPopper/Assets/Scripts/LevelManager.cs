using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}

	public void QuitGame()
	{
		Debug.Log("Quit");
		
		Application.Quit();
	}

	public void GoBack()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
	}
	
}
