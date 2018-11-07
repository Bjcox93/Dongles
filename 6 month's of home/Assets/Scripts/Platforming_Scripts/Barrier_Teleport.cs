using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier_Teleport : MonoBehaviour {

    public GameObject Player;
    public GameObject Tank;
    public GameObject Barrier_Destination;
    public GameObject Barrier_Destination2;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Barrier")
        {
            Player.transform.position = Barrier_Destination.transform.position;

            if (Movement.instance.playerActive == false)
            {
                Player.transform.position = Barrier_Destination.transform.position;
                Tank.transform.position = Barrier_Destination.transform.position;
                Tank.transform.rotation = Barrier_Destination.transform.rotation;
            }
        }
    }
}
