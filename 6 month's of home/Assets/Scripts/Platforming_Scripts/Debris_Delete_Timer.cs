using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris_Delete_Timer : MonoBehaviour {
    public float countdown;

    private void Awake()
    {
        Destroy(gameObject, 3f);
    }

    // Use this for initialization
    void Start () {
        countdown = 4f;
	}
	
	// Update is called once per frame
	void Update () {
        if (countdown <= 0f)
        {
            Destroy(gameObject);
        }
	}
}
