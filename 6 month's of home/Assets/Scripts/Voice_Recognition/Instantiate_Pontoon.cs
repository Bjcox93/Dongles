using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Pontoon : MonoBehaviour {
    public static Instantiate_Pontoon instance;
    public GameObject Pontoon_Letters;
    public GameObject Letter_Bridge;
    public GameObject Ramp;
    public int DropForce;

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

    public void MakePontoon()
    {

        Pontoon_Letters.SetActive(true);

    }

    public void OpenBridge()
    {
        Letter_Bridge.SetActive(true);
    }

    public void OpenRamp()
    {
        Ramp.SetActive(true);
    }

}
