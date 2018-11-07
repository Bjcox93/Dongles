using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    public Rigidbody tankRb;
    public float bounceForce = 25f;

    private float nextActionTime = 0.0f;
    private float period = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            
            bounce();
        }
    }

    public void bounce()
    {
        //tankRb.AddForce(Vector3.up * bounceForce);
        

        Debug.Log("BOUNCE");
    }
}
