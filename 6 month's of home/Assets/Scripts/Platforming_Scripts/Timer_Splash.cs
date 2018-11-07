using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_Splash : MonoBehaviour {

    public float timek = 2.0f;
    // Use this for initialization
    void Start () {
		
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
