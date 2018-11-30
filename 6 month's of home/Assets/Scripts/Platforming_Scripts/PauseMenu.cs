using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject TutorialObject;

    //Lerp
    public GameObject ContinueNewGO;
    public Transform TargetContinue_Start;
    public Transform TargetContinue_End;

    public GameObject ButtonContinueNewGO;
    public Transform ButtonTargetContinue_Start;
    public Transform ButtonTargetContinue_End;

    public GameObject ResumeNewGO;
    public Transform TargetResume_Start;
    public Transform TargetResume_End;

    public GameObject ButtonResumeNewGO;
    public Transform ButtonTargetResume_Start;
    public Transform ButtonTargetResume_End;

    public GameObject MenuNewGO;
    public Transform TargetMenu_Start;
    public Transform TargetMenu_End;

    public GameObject ButtonMenuNewGO;
    public Transform ButtonTargetMenu_Start;
    public Transform ButtonTargetMenu_End;


    public float SpeedOfMove;

    //Lerp Bools
    public bool LerpContinue;
    public bool LerpResume;
    public bool LerpMenu;


    // Use this for initialization
    void Start () {
        LerpContinue = false;
        LerpMenu = false;
        LerpResume = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TutorialObject.SetActive(false);
        }

        if (LerpContinue == true)
        {
            ContinueNewGO.transform.position = Vector3.Lerp(TargetContinue_Start.transform.position, TargetContinue_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonContinueNewGO.transform.position = Vector3.Lerp(ButtonTargetContinue_Start.transform.position, ButtonTargetContinue_End.transform.position, SpeedOfMove * Time.deltaTime);
            GameManager.instance.LoadGame();
        }

        if (LerpResume)
        {
            ResumeNewGO.transform.position = Vector3.Lerp(TargetResume_Start.transform.position, TargetResume_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonContinueNewGO.transform.position = Vector3.Lerp(ButtonTargetResume_Start.transform.position, ButtonTargetResume_End.transform.position, SpeedOfMove * Time.deltaTime);

            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        if (LerpMenu)
        {
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonContinueNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);

            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            SceneManager.LoadScene("Title_Menu");
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        LerpResume = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        LerpMenu = true;
        /*pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Title_Menu");*/
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void LoadGame()
    {
        LerpContinue = true;
        //GameManager.instance.LoadGame();
    }
}
