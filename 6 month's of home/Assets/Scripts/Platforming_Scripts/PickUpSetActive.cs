using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSetActive : MonoBehaviour {

    public GameObject PickUPscript;


	// Use this for initialization
	void Awake () {
      

        PickUPscript.GetComponent<PickUp>().enabled = false;
        Debug.Log("PickUp off");
    }

  

    // Update is called once per frame
    void Update () {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Pick Up")
        {
            PickUPscript.GetComponent<PickUp>().enabled = true;
            Debug.Log("PickUp true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUPscript.GetComponent<PickUp>().enabled = false;
        Debug.Log("PickUp off");
    }
}
