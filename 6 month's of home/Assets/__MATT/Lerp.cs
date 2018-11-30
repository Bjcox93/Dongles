using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour {

    public float speed = 1f;
    public Vector3 endPos;

    // Update is called once per frame
    void Update ()
    {

        transform.position = Vector3.Lerp(transform.position, endPos, speed * Time.deltaTime);


	}
}
