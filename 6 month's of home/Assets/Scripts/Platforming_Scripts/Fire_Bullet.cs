using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Bullet : MonoBehaviour {

    public static Fire_Bullet instance;

    public GameObject projectile;
    public int FireForce;

    
    
	// Use this for initialization
	void Start () {
        
	}


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


    }

    // Update is called once per frame
    void Update () {

        //if (Input.GetKeyDown(KeyCode.Space) && Movement.instance.playerActive == false)
       // {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * FireForce);
            

            
       // }


	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Letter")
        {
           
        }

        if (collision.gameObject.name == "Killer")
        {
            Destroy_Bullet.instance.DestroyBulletFun();
        }
    }

    //Voice fire
    public void voiceFire()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * FireForce);
    }
}
