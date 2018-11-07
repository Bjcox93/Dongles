using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	public static GameManager instance;

	public int currentLevel;

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
		currentLevel = SaveLoadManager.LoadPlayer();
	}

	public void SaveGame()
	{
		SaveLoadManager.SavePlayer();
	}

	private void OnApplicationQuit()
	{
		SaveGame();
	}
}
