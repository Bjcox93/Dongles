using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Dropper : MonoBehaviour {

    public GameObject TankDropper;
    public GameObject PlaneDropper;
   

	// Use this for initialization
	void Start () {
        PlaneDropper.SetActive(false);
        TankDropper.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Tank"))
        {
            TankDropper.SetActive(false);
            PlaneDropper.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Tank"))
        {
            TankDropper.SetActive(true);
            PlaneDropper.SetActive(false);
        }
    }
}
