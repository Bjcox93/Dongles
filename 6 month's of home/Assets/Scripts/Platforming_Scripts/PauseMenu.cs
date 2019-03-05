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

    public AudioClip BigClick;
    public AudioSource AudioSource;


    public float SpeedOfMove;

    //Lerp Bools
    public bool LerpContinue;
    public bool LerpResume;
    public bool LerpMenu;


    //Coroutine Stuff:
    public float waitTime = 3;
    public AnimationCurve buttonAnimationCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    // Time when the movement started.
    private float startTime;


    // Use this for initialization
    void Start () {
        LerpContinue = false;
        LerpMenu = false;
        LerpResume = false;
        AudioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && CameraMovemement.instance.PauseBlock == false)
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

        /*if (LerpContinue == true)
        {
            ContinueNewGO.transform.position = Vector3.Lerp(TargetContinue_Start.transform.position, TargetContinue_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonContinueNewGO.transform.position = Vector3.Lerp(ButtonTargetContinue_Start.transform.position, ButtonTargetContinue_End.transform.position, SpeedOfMove * Time.deltaTime);
            GameManager.instance.LoadGame();
        }

        if (LerpResume)
        {
            ResumeNewGO.transform.position = Vector3.Lerp(TargetResume_Start.transform.position, TargetResume_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonResumeNewGO.transform.position = Vector3.Lerp(ButtonTargetResume_Start.transform.position, ButtonTargetResume_End.transform.position, SpeedOfMove * Time.deltaTime);

            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        if (LerpMenu)
        {
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonMenuNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);

            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            SceneManager.LoadScene("Title_Menu");
        }*/
	}

    IEnumerator WaitForContinueButton()
    {
        for (float t = 0; t < waitTime; t += Time.deltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            ContinueNewGO.transform.position = Vector3.Lerp(TargetContinue_Start.transform.position, TargetContinue_End.transform.position, progression);
            ButtonContinueNewGO.transform.position = Vector3.Lerp(ButtonTargetContinue_Start.transform.position, ButtonTargetContinue_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
        }
        GameManager.instance.LoadGame();
    }

    IEnumerator WaitForResumeButton()
    {
        for (float t = 0; t < waitTime; t += Time.unscaledDeltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            ResumeNewGO.transform.position = Vector3.Lerp(TargetResume_Start.transform.position, TargetResume_End.transform.position, progression);
            ButtonResumeNewGO.transform.position = Vector3.Lerp(ButtonTargetResume_Start.transform.position, ButtonTargetResume_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
        }
        pauseMenuUI.SetActive(false);
        ResumeNewGO.transform.position = TargetResume_Start.transform.position;
        ButtonResumeNewGO.transform.position = ButtonTargetResume_Start.transform.position;
       Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("resume");
    }

    IEnumerator WaitForMenuButton()
    {
        Debug.Log("menu");
        Debug.Log(Time.deltaTime);

        AudioSource.PlayOneShot(BigClick, Audio_On_Collision.sfxVolume);
        for (float t = 0; t < waitTime; t += Time.unscaledDeltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, progression);
            ButtonMenuNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
            Debug.Log("menu");
        }
        Debug.Log("menu");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("menu");
        SceneManager.LoadScene("Title_Menu");
        AudioManager.instance.PlayLvl10Music();
    }

    public void Resume()
    {
        Debug.Log("resumebuttonpressed");
        StartCoroutine(WaitForResumeButton());
       /* LerpResume = true;
       pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;*/
    }

    void Pause()
    {
        
        //LerpResume = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {

        Debug.Log("loadbuttonpressed");
        StartCoroutine(WaitForMenuButton());
        /*LerpMenu = true;
        pauseMenuUI.SetActive(false);
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
