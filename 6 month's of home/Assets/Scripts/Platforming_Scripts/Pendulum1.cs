using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum1 : MonoBehaviour
{

    public Transform Target1;
    public Transform Target2;
    public Transform OriginalTarget;
    public bool there;
    public bool back;

    public float SpeedOfMove;

    private void Start()
    {
        there = true;
        back = false;
}

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = SpeedOfMove * Time.deltaTime;

        // Move our position a step closer to the target.
        if (there == true) {
            transform.position = Vector3.MoveTowards(transform.position, Target1.position, step);

            if (gameObject.transform.position == Target1.transform.position)
            {
                there = false;
                back = true;
 }
        }

        if (back == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, OriginalTarget.position, step);

            if (gameObject.transform.position == OriginalTarget.transform.position)
            {
                there = true;
                back = false;
            }
        }

       
    }
}
