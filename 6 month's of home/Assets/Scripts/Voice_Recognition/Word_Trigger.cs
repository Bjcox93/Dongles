using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word_Trigger : MonoBehaviour {
    public static Word_Trigger instance;
    public bool TalkZone1;
    public GameObject Zone1;

    public bool TalkZone2;
    public GameObject Zone2;
    // Use this for initialization

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        TalkZone1 = false;
        TalkZone2 = false;
    }

    void Start () {
        TalkZone1 = false;
        TalkZone2 = false;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Word_Tigger")
        {
            TalkZone1 = true;
            TalkZone2 = false;
            if (TalkZone1 == true)
            {
                Zone1.GetComponent<Renderer>().material.color = Color.red;
            }

            if (TalkZone2 == true)
            {
                Zone2.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
