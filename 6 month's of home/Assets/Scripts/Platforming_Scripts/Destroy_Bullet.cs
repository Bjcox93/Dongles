using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour {

    public static Destroy_Bullet instance;

    public GameObject bullet;

    // Use this for initialization
    private void Awake()
    {


        if (instance != null)
        {
            Debug.Log("fuck_V3");
        }
        else
        {
            instance = this;
        }

        Destroy(bullet, 2);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Killer")
        {
            Destroy(bullet, 0);
        }
    }


    public void DestroyBulletFun()
    {
        Destroy(bullet,0);
    }
}
