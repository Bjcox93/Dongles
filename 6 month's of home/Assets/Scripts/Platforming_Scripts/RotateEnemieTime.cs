using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemieTime : MonoBehaviour {

    public float RotateEquals;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, RotateEquals, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
