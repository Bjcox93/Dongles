using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

    public GameObject StartNewGO;
    public Transform Target1StartNew; 
    public Transform OriginalTargetStartNew;

    public GameObject ExitGO;
    public Transform Target1Exit;
    public Transform OriginalTargetExit;

    public GameObject ContinueGO;
    public Transform Target1Continue;
    public Transform OriginalTargetContinue;

    public GameObject OptionsGO;
    public Transform Target1Options;
    public Transform OriginalTargetOptions;

    public float SpeedOfMove;

    public GameObject MainMenuUI;

    //Bools
    public bool StartNewWait;
    


	// Use this for initialization
	void Start () {
        Reset.instance.ScoreCanvas.SetActive(true);
        StartNewWait = false;
        
    }

    // Update is called once per frame
    public void Update()
    {
        //float Step = SpeedOfMove * Time.deltaTime;
    }

    public void StartNew()
    {
        StartNewGO.transform.position = Vector3.MoveTowards(transform.position, Target1StartNew.position, SpeedOfMove * Time.deltaTime);
        // if shape to target load level bool = true. If load level bool == true then load level.
        StartNewWait = true;

        if (StartNewWait == true)
        {
            SceneManager.LoadScene("LEVEL_2");
        }
    }

   

    public void OptionsMenu()
    {
        OptionsGO.transform.position = Vector3.MoveTowards(transform.position, Target1Options.position, SpeedOfMove * Time.deltaTime);
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
        ExitGO.transform.position = Vector3.MoveTowards(transform.position, Target1Exit.position, SpeedOfMove * Time.deltaTime);
        Debug.Log("QUIT");
        Application.Quit();
        
    }

 
}
