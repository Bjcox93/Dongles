using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_Zone : MonoBehaviour {

    public bool QuestionZone;
    

    public static Question_Zone instance;

     void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        QuestionZone = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Word_Trigger"))
        {
            QuestionZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Word_Trigger"))
        {
            QuestionZone = false;
        }
    }
}
