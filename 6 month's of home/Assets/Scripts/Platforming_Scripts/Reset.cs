﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);

            scoreAmount = scoreAmount + 1;

            //TutorialNotes
            GameManager.instance.tutorialBoolFalse();
            press_space.SetActive(false);
            press_b.SetActive(false);
            
           
        }

        //TutorialNotesCont
        if (Input.GetKeyDown(KeyCode.B) && GameManager.instance.tutorialUI == true)
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
