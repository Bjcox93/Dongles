using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

    

    public GameObject MainMenuUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	

    public void StartNew()
    {
        SceneManager.LoadScene("LEVEL_2");
    }

   

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Title_Menu_Options");
    }

    public void LoadLevelLoadMenu()
    {
        SceneManager.LoadScene("Title_Menu_LOAD_LEVEL");
    }

    public void LoadControlsMenu()
    {
        SceneManager.LoadScene("Title_Menu_Controls");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        
    }

 
}
