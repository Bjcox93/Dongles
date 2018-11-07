using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Press_1 : MonoBehaviour {

    public Text press_b;
    public Text press_space;

    

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            press_b.text = "";
            Debug.Log("B");

            press_space.text = "PRESS SPACE TO RESET";
            Debug.Log("Space");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            press_space.text = "";
            Debug.Log("Space");
            
           
        }
    }
}
