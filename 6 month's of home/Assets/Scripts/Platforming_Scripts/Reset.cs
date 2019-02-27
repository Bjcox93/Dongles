using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour {
    public SceneTransition SceneTrans0;
    public SceneTransition1 SceneTrans1;
    public SceneTransition2 SceneTrans2;
    public SceneTransition3 SceneTrans3;
    public SceneTransition4 SceneTrans4;
    public SceneTransition6 SceneTrans6;
    public SceneTransition7 SceneTrans7;
    public SceneTransition8 SceneTrans8;
    public SceneTransition15 SceneTrans15;
    public SceneTransition16 SceneTrans16;

    public static Reset instance = null;

    public Text scoreText;
    public float scoreAmount;

    //Don't destoy on loads;

    public GameObject ScoreCanvas;
    public GameObject ResetObj;
    public GameObject TutorialNotes;
    public GameObject press_b;
    public GameObject press_space;

    private void Awake()
    {
        scoreAmount = 0;

        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
       
    }

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(ScoreCanvas);
        DontDestroyOnLoad(ResetObj);
        DontDestroyOnLoad(TutorialNotes);
        DontDestroyOnLoad(press_b);
        DontDestroyOnLoad(press_space);
        


        if (GameManager.instance.tutorialUI == true)
        {
            press_b.SetActive(true);
            press_space.SetActive(false);
        }

        if (GameManager.instance.tutorialUI == false)
        {
            press_space.SetActive(false);
            press_b.SetActive(false);
        }


    }
	
	// Update is called once per frame
	void Update () {

        scoreText.text = scoreAmount.ToString();

        if (Input.GetMouseButtonDown(1))
        {
            if(SceneTrans0 != null && !SceneTrans0.EndLevel0 || SceneTrans1 != null && !SceneTrans1.EndLevel1 || SceneTrans2 != null && !SceneTrans2.EndLevel2 || 
                SceneTrans3 != null && !SceneTrans3.EndLevel3 || SceneTrans4 != null && !SceneTrans4.EndLevel4 || SceneTrans6 != null && !SceneTrans6.EndLevel6 ||
                SceneTrans7 != null && !SceneTrans7.EndLevel7 || SceneTrans8 != null && !SceneTrans8.EndLevel8 || SceneTrans15 != null && !SceneTrans15.EndLevel15
                || SceneTrans16 != null && !SceneTrans16.EndLevel16)
            {
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);

                scoreAmount = scoreAmount + 1;

                //TutorialNotes
                GameManager.instance.tutorialBoolFalse();
                press_space.SetActive(false);
                press_b.SetActive(false);
            }
           
        }

        //TutorialNotesCont
        if (Input.GetMouseButtonDown(0) && GameManager.instance.tutorialUI == true)
        {
            press_b.SetActive(false);
            press_space.SetActive(true);
        }

    }

    public void ResetFun()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);

        scoreAmount = scoreAmount + 1;
    }
}
