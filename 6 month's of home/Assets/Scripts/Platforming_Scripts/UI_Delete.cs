using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Delete : MonoBehaviour {
    public static UI_Delete instance;

    public bool UI_DONE;
	// Use this for initialization
	void awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        if (UI_DONE == true)
        {

        }
	}

    
}
