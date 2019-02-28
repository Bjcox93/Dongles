using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_Splash : MonoBehaviour {

    public float timek = 2.0f;
    // Use this for initialization
    void Start () {
        try
        {
            Reset.instance.scoreAmount = 0;
            Reset.instance.ScoreCanvas.SetActive(false);
        }

        catch (Exception)
        {
            Debug.Log("Error Caught");
        }
	}
	
	// Update is called once per frame
	void Update () {
        timek -= Time.deltaTime;

        if (timek < 0 )
        {
            SceneManager.LoadScene("Title_Menu");
        }
    }
}
