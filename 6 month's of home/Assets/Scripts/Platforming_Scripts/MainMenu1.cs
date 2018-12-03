using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

    public GameObject StartNewGO;
    public Transform TargetStartNew_Start; 
    public Transform TargetStartNew_End;

    public GameObject ExitGO;
    public Transform TargetExit_Start;
    public Transform TargetExit_End;

    public GameObject OptionsGO;
    public Transform TargetOptions_Start;
    public Transform TargetOptions_End;

    //Buttons
    public Transform ButtonStartNew_Start;
    public Transform ButtonOptions_Start;
    public Transform ButtonExit_Start;

    public Transform ButtonStartNew_End;
    public Transform ButtonOptions_End;
    public Transform ButtonExit_End;

    public GameObject ButtonsStartNewGO;
    public GameObject ButtonsOptionsGO;
    public GameObject ButtonsExitGO;

    public float SpeedOfMove;

    public GameObject MainMenuUI;

    //Bools
    public bool StartNewWait;
    public bool OptionsBool;
    public bool ExitBool;

    public bool LerpStart;
    public bool LerpOptions;
    public bool LerpExit;

    //Lerp
    //Time for animaitons
    public float waitTime = 3;
    public AnimationCurve buttonAnimationCurve = AnimationCurve.EaseInOut(0,0,1,1);
    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;


    // Use this for initialization
    void Start () {
        Reset.instance.ScoreCanvas.SetActive(true);
        StartNewWait = false;
        OptionsBool = false;
        ExitBool = false;
        LerpStart = false;
        LerpOptions = false;
        LerpExit = false;

       
    }

    // Update is called once per frame
    public void Update()
    {
        /*
        if (LerpStart)
        {
            StartNewGO.transform.position = Vector3.Lerp(TargetStartNew_Start.transform.position, TargetStartNew_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonsStartNewGO.transform.position = Vector3.Lerp(ButtonStartNew_Start.transform.position, ButtonStartNew_End.transform.position, SpeedOfMove * Time.deltaTime);
            StartNewWait = true;
            print("StartNewWait: " + StartNewWait);

        }
        
        if (LerpOptions)
        {
            OptionsGO.transform.position = Vector3.Lerp(TargetOptions_Start.transform.position, TargetOptions_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonsOptionsGO.transform.position = Vector3.Lerp(ButtonOptions_Start.transform.position, ButtonOptions_End.transform.position, SpeedOfMove * Time.deltaTime);
            OptionsBool = true;
        }

        if (LerpExit)
        {
            ExitGO.transform.position = Vector3.Lerp(TargetExit_Start.transform.position, TargetExit_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonsExitGO.transform.position = Vector3.Lerp(ButtonExit_Start.transform.position, ButtonExit_End.transform.position, SpeedOfMove * Time.deltaTime);
            ExitBool = true;
        }*/

        //Position equals position
        if (StartNewGO.transform.position == TargetStartNew_End.transform.position)
        {
            StartNewWait = true; 
        }


    }

    /*
    public void StartNew()
    {
        LerpStart = true;
        //startNewLerp();

        if (StartNewWait == true)
        {
            SceneManager.LoadScene("LEVEL_2");
        }
    }*/

    public void StartNew()
    {
        StartCoroutine(WaitForStartButton());
    }

    IEnumerator WaitForStartButton()
    {
        for(float t = 0; t < waitTime; t += Time.deltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            StartNewGO.transform.position = Vector3.Lerp(TargetStartNew_Start.transform.position, TargetStartNew_End.transform.position, progression);
            ButtonsStartNewGO.transform.position = Vector3.Lerp(ButtonStartNew_Start.transform.position, ButtonStartNew_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
        }
        SceneManager.LoadScene("LEVEL_2");
    }

    IEnumerator WaitForOptionsButton()
    {
        for (float t = 0; t < waitTime; t += Time.deltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            OptionsGO.transform.position = Vector3.Lerp(TargetOptions_Start.transform.position, TargetOptions_End.transform.position, progression);
            ButtonsOptionsGO.transform.position = Vector3.Lerp(ButtonOptions_Start.transform.position, ButtonOptions_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
        }
        SceneManager.LoadScene("Title_Menu_Options");
    }

    IEnumerator WaitForQuitButton()
    {
        for (float t = 0; t < waitTime; t += Time.deltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            ExitGO.transform.position = Vector3.Lerp(TargetExit_Start.transform.position, TargetExit_End.transform.position, progression);
            ButtonsExitGO.transform.position = Vector3.Lerp(ButtonExit_Start.transform.position, ButtonExit_End.transform.position, progression);
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void OptionsMenu()
    {
        StartCoroutine(WaitForOptionsButton());
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
        StartCoroutine(WaitForQuitButton());

    }

    public void startNewLerp()
    {
        //Trigger end Scene
        StartNewWait = true;
    }

    public void OptionsLerp()
    {
        OptionsBool = true;
    }

    public void ExitLerp()
    {
        
        ExitBool = true;
    }

}
