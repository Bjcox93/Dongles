using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float delay = 3f;
    public float countdown;
    bool hasExplodede = false;
    public float blastRadius = 5f;
    public float force = 700f;
    public GameObject explosionClone;

    public GameObject ExplosionEffect;

    private void Start()
    {
        countdown = delay;
    }


    void update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && hasExplodede == false)
        {
            Explode();
        }
    }

    void Explode()
    {
        //Particles;
        Instantiate(ExplosionEffect, transform.position, transform.rotation);

        //Residual destruction;
        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, blastRadius);
                Destroy(nearbyObject.gameObject, 1f);
                Destroy(explosionClone.gameObject, 1f);
            }
        }


        //Destroy bomb;
        Destroy(gameObject);


    }
}
