using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSetActive1 : MonoBehaviour {

    public GameObject PickUPscript1;


	// Use this for initialization
	void Awake () {
      

        PickUPscript1.GetComponent<PickUp1>().enabled = false;
        Debug.Log("PickUp off");
    }

  

    // Update is called once per frame
    void Update () {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Pick Up")
        {
            PickUPscript1.GetComponent<PickUp1>().enabled = true;
            Debug.Log("PickUp true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUPscript1.GetComponent<PickUp1>().enabled = false;
        Debug.Log("PickUp off");
    }
}
