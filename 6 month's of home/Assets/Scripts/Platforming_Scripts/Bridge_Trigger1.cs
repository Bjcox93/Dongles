using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Trigger1 : MonoBehaviour {
  

    public GameObject BridgeObject2;
    public GameObject BridgeObjectShadow2;
    public GameObject BridgeTrigger2;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        

        if (gameObject.tag == "Bridge2")
        {
            BridgeObject2.transform.position = BridgeObjectShadow2.transform.position;
            BridgeObject2.transform.rotation = BridgeObjectShadow2.transform.rotation;
            BridgeObject2.transform.localScale = BridgeObjectShadow2.transform.localScale;
            BridgeTrigger2.SetActive(false);
        }
    }
}
