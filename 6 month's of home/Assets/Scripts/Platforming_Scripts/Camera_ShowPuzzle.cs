using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ShowPuzzle : MonoBehaviour
{

    public static Camera_Horizon instance;

    public Transform CameraDestination1;
    public GameObject Camera;
    public bool turnONCamera;
   

  

    public float SpeedOfMove;

    // Use this for initialization
    private void Awake()
    {
        Camera.GetComponent<CameraMovemement>().enabled = false;
        Camera.GetComponent<Camera_ShowPuzzle>().enabled = true;
        turnONCamera = false;
        Debug.Log("Flag3");
    }

   

    // Update is called once per frame
    void Update()
    {
        float step = SpeedOfMove * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, CameraDestination1.position, step);
        turnONCamera = true;
        Debug.Log("Flag2");


        if (turnONCamera == true)
        {
            Camera.GetComponent<CameraMovemement>().enabled = true;
            Camera.GetComponent<Camera_ShowPuzzle>().enabled = false;

            Debug.Log("Flag1");
        }



    }
}
