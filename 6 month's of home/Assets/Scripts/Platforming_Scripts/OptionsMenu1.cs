using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu1 : MonoBehaviour {

    

    public GameObject MainMenuUI;

    //Lerp
    public GameObject MenuNewGO;
    public Transform TargetMenu_Start;
    public Transform TargetMenu_End;

    public GameObject ButtonMenuNewGO;
    public Transform ButtonTargetMenu_Start;
    public Transform ButtonTargetMenu_End;

    public AudioClip Whoop;
    public AudioSource AudioSource;

    public Animator animator;

    public float SpeedOfMove;

    //Lerp Bools
    public bool LerpMenu;

    //Coroutine Stuff:
    public float waitTime = 3;
    public AnimationCurve buttonAnimationCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    // Time when the movement started.
    private float startTime;

    public bool TransitionSoundPlaying;

    // Use this for initialization
    void Start () {
        LerpMenu = false;
        TransitionSoundPlaying = false;
	}

    // Update is called once per frame
    public void Update()
    {
        AudioSource = GetComponent<AudioSource>();
        if (LerpMenu == true)
        {
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonMenuNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            SceneManager.LoadScene("Title_Menu");
        }
    }

    IEnumerator WaitForOptionsMenuButton()
    {
        TransitionSoundPlaying = true;
        for (float t = 0; t < waitTime; t += Time.deltaTime)
        {
            if (TransitionSoundPlaying == true) {
                AudioSource.PlayOneShot(Whoop, Audio_On_Collision.sfxVolume);
            }
            FadeOut();
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, progression);
            ButtonMenuNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, progression);
            yield return new WaitForEndOfFrame();

            TransitionSoundPlaying = false;
        }
        SceneManager.LoadScene("Title_Menu");
    }


    public void StartNew()
    {
        SceneManager.LoadScene("LEVEL_1");
    }

   

    public void MainMenu()
    {
        StartCoroutine(WaitForOptionsMenuButton());
        //LerpMenu = true;
        //SceneManager.LoadScene("Title_Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("LEVEL_2");
    }

    public void Level2()
    {
        SceneManager.LoadScene("LEVEL_1");
    }

    public void Level3()
    {
        SceneManager.LoadScene("LEVEL_3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("LEVEL_4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("LEVEL_5");
    }

    public void FadeOut()
    {
        animator.SetTrigger("FadeIn");
    }
}
