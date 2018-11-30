using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGEOPOS : MonoBehaviour {

    public GameObject Geo;
    public GameObject Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Geo.transform.position = Text.transform.position;

    }
}
