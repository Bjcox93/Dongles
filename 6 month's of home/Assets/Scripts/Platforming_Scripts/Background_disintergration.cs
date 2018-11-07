using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_disintergration : MonoBehaviour {

    public static Background_disintergration instance;

    public Transform Destination;
    public Transform OriginalDestination;


    public bool there;
    public bool back;

    public bool disGrayRan;

    public float SpeedOfMove;
    public float countdown = 10f;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Shit");
        }

        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        there = false;
        back = true;
        disGrayRan = false;
    }
	
	// Update is called once per frame
	void Update () {

        countdown -= Time.deltaTime;
        if (countdown <= 0.0f && disGrayRan == false)
        {
            there = true;
            back = false;
            disGrayRan = true;
        }

        float step = SpeedOfMove * Time.deltaTime;


        // Move our position a step closer to the target.
        if (there == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Destination.position, step);
           

            if (gameObject.transform.position == Destination.transform.position)
            {
                there = false;
                back = true;
            }
        }

        if (back == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, OriginalDestination.position, step);

            if (gameObject.transform.position == OriginalDestination.transform.position)
            {
                there = true;
                back = false;
            }
        }
    }
}
