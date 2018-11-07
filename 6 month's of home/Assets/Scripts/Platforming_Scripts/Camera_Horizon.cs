using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Horizon : MonoBehaviour {

    public static Camera_Horizon instance;

    public Transform CameraDestination1;
    public Transform CameraDestination2;
    public Transform CameraDestinationOrigin;

    public bool MoveCameraForward;
    public bool MoveCameraBack;
    public bool MoveCameraNo;

    public float SpeedOfMove;

    // Use this for initialization
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Badthing3");
        }

        else
        {
            instance = this;
        }
    }

    void Start () {
        MoveCameraForward = false;
        MoveCameraBack = false;
	}
	
	// Update is called once per frame
	void Update () {
        float step = SpeedOfMove * Time.deltaTime;

        if (MoveCameraForward == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, CameraDestination1.position, step);
        }

        if (MoveCameraBack == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, CameraDestination2.position, step);
        }
    }

    public void MoveCameraForwardTrue()
    {
        MoveCameraForward = true;
        MoveCameraBack = false;
    }

    public void MoveCameraForwardFalse()
    {
        MoveCameraForward = false;
       
    }

    public void MoveCameraBackTrue()
    {
        MoveCameraForward = false;
        MoveCameraBack = true;
    }

    public void MoveCameraBackFalse()
    {
        
        MoveCameraBack = false;
    }

    public void MoveCameraStop()
    {
        MoveCameraForward = false;
        MoveCameraBack = false;
    }


}
