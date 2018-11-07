using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu1 : MonoBehaviour {

    

    public GameObject MainMenuUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	

    public void StartNew()
    {
        SceneManager.LoadScene("LEVEL_1");
    }

   

    public void MainMenu()
    {
        SceneManager.LoadScene("Title_Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        
    }
}
