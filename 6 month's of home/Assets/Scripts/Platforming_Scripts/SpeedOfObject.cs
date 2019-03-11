using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedOfObject : MonoBehaviour {

    public Rigidbody rb;

    public float timeP = 2.0f;
    public float timeO = 2.0f;
    public float timeF = 30.0f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        float vel = rb.velocity.magnitude;
        
        //Debug.Log(vel);

        timeP -= Time.deltaTime;
        

        if (timeP < 0)
        {
            if (vel < 0.01f)
            {
                timeO -= Time.deltaTime;
                if (timeO < 0)
                {
                    Debug.Log("Freeze");
                    Reset.instance.ResetFun();
                    timeO = 5.0f;
                }
            }

            if (vel < 15)
            {
                Debug.Log("Normal");
            }

             if (vel > 37)
            {

                timeF -= Time.deltaTime;
                if (timeF < 0)
                {
                    Debug.Log("Hot");
                   // Reset.instance.ResetFun();
                    timeF = 30.0f;
                }
            }
        }
        

	}
}
