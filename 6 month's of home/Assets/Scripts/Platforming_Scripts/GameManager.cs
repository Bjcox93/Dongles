using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	public static GameManager instance;

	public string currentLevel;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != null)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}

	public void LoadGame()
	{
		currentLevel = SaveLoadManager.LoadFile();
		if(currentLevel != ""){
			SceneManager.LoadScene (currentLevel);
		}

	}

	public void SaveGame()
	{
		SaveLoadManager.SaveFile();
	}

	private void OnApplicationQuit()
	{
		SaveGame();
	}
}
