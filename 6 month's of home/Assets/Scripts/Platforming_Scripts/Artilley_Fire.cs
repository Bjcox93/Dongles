using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artilley_Fire : MonoBehaviour
{
     public Rigidbody projectile;
    
     public GameObject fireposition;
    public GameObject explosionposition;
    public GameObject Bomb;
    public GameObject ParticlesEGO;
     private void Start()
     {
        InvokeRepeating("OncannonPuff", 3.0f, 3.0f);
        InvokeRepeating("OffcannonPuff", 4.0f, 4.0f);
        InvokeRepeating("FireArtillery", 5.0f, 5.0f);
        ParticlesEGO.SetActive(false);
         
     }

     private void Update()
     {
       
    }

     public void FireArtillery()
     {


         Rigidbody clone;
         clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
         clone.velocity = transform.TransformDirection(Vector3.forward * 10);

         clone.transform.position = fireposition.transform.position;

        Instantiate(Bomb, explosionposition.transform.position, explosionposition.transform.rotation);

        Destroy(Bomb.gameObject, 1f);
        Destroy(clone.gameObject, 5f);
        
         
    }

    public void OncannonPuff()
    {
        ParticlesEGO.SetActive(true);

    }

    public void OffcannonPuff()
    {
        ParticlesEGO.SetActive(false);
    }


  


 

}