using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intensity : MonoBehaviour
{

    public static Intensity instance;
    public Transform ObjTrans1;
    public Transform ObjTrans2;
    private Vector3 Vec1;
    public Light LightIntensity;
    public float amplitude;


    //--------------------------------------
    public bool noMove = false;



    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Bad");
        }

        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vec1 = ObjTrans1.position - ObjTrans2.position;

        float distance = Mathf.Sqrt(Mathf.Pow(Vec1.x, 2) + Mathf.Pow(Vec1.y, 2) + Mathf.Pow(Vec1.z, 2));



        LightIntensity.intensity = amplitude * (distance - 20f) / -0.6895552f;
        if (distance == 20)
        {
            LightIntensity.intensity = 0;
        }

        


    }



}