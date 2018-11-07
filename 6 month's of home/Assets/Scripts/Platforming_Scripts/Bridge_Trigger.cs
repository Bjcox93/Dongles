using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Trigger : MonoBehaviour {
    public GameObject BridgeObject1;
    public GameObject BridgeObjectShadow1;
    public GameObject BridgeTrigger1;

    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Bridge")
        {
            BridgeObject1.transform.position = BridgeObjectShadow1.transform.position;
            BridgeObject1.transform.rotation = BridgeObjectShadow1.transform.rotation;
            BridgeObject1.transform.localScale = BridgeObjectShadow1.transform.localScale;
            BridgeTrigger1.SetActive(false);
        }

      
    }
}
