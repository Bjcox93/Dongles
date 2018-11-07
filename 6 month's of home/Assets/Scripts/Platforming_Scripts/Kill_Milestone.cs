using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Milestone : MonoBehaviour {

    public GameObject milestone1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Tank")
        {
            Destroy(milestone1);
            Debug.Log("Delete");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
