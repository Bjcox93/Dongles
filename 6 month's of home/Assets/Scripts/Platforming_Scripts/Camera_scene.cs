using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player" ) || other.CompareTag("Tank"))
        {
            CameraMovemement.instance.offSet.x = CameraMovemement.instance.offSet.x + 15;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Tank"))
        {
            CameraMovemement.instance.offSet.x = CameraMovemement.instance.offSet.x - 15;
        }
    }
}

