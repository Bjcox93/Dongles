using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {
    public static ColourChange instance;

    
  
    public GameObject Monkey;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

   

    // Update is called once per frame
    public void MakeRed()
    {

        Monkey.GetComponent<Renderer>().material.color = Color.red;

    }
}
