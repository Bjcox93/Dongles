﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPosAlt : MonoBehaviour {
  

    public GameObject BridgeObject2;
    public GameObject BridgeObjectShadow2;

    public GameObject OriginalPos;

    Coroutine cannonRotate_1;
    Coroutine cannonRotate_2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (cannonRotate_2 != null) { StopCoroutine(cannonRotate_2); }
            cannonRotate_1 = StartCoroutine(LerpDistance(BridgeObject2.transform, BridgeObjectShadow2.transform.position, BridgeObjectShadow2.transform.localScale, BridgeObjectShadow2.transform.rotation, 1));
            /*BridgeObject2.transform.position = BridgeObjectShadow2.transform.position;
            BridgeObject2.transform.rotation = BridgeObjectShadow2.transform.rotation;
            BridgeObject2.transform.localScale = BridgeObjectShadow2.transform.localScale;*/
        }

        else if (Input.GetKeyUp(KeyCode.N))
        {
            if (cannonRotate_1 != null) { StopCoroutine(cannonRotate_1); }
            cannonRotate_2 = StartCoroutine(LerpDistance(BridgeObject2.transform, OriginalPos.transform.position, OriginalPos.transform.localScale, OriginalPos.transform.rotation, 1));
            /*BridgeObject2.transform.position = OriginalPos.transform.position;
            BridgeObject2.transform.rotation = OriginalPos.transform.rotation;
            BridgeObject2.transform.localScale = OriginalPos.transform.localScale;
            */
        }
    
    }

    IEnumerator LerpDistance(Transform cannon, Vector3 newPosition, Vector3 newScale, Quaternion newRotation, float animationTime)
    {
        Vector3 initialPos = cannon.position;
        Vector3 initialScale = cannon.localScale;
        Quaternion initialRotation = cannon.rotation;
        for (float t = 0; t < animationTime; t += Time.deltaTime)
        {
            float currentTime = t / animationTime;
            cannon.position = Vector3.Lerp(initialPos, newPosition, currentTime);
            cannon.localScale = Vector3.Lerp(initialScale, newScale, currentTime);
            cannon.rotation = Quaternion.Slerp(initialRotation, newRotation, currentTime);
            yield return new WaitForEndOfFrame();
        }
        cannon.position = newPosition;
        cannon.localScale = newScale;
        cannon.rotation = newRotation;
    }

  
}
