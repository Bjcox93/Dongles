using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum2 : MonoBehaviour
{

    public static Pendulum2 instance = null;

    public Transform Target1;
    public Transform Target2;
    public Transform OriginalTarget;
    public bool there;
    public bool back;

    public float SpeedOfMove;

    private void Awake()
    {
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }

    private void Start()
    {
        there = false;
        back = false;
}

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = SpeedOfMove * Time.deltaTime;

        // Move our position a step closer to the target.
        if (there == true) {
            OriginalTarget.transform.position = Vector3.MoveTowards(transform.position, Target1.transform.position, step);
            OriginalTarget.transform.localScale = Vector3.MoveTowards(transform.localScale,Target1.localScale,step);
           



 }
    }

    public void GetBigger()
    {
        there = true;
    }
}
