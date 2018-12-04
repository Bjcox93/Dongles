using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	public static GameManager instance;

	public string currentLevel;

    public bool tutorialUI;

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
        tutorialUI = true;
    }

    public void start()
    {
        tutorialUI = true;
    }

    public void tutorialBoolFalse()
    {
        tutorialUI = false;
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
