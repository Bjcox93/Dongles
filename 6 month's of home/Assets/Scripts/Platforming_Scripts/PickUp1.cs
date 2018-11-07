using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PickUp1 : MonoBehaviour
{
    public static PickUp1 instance;

    public float throwSpeed;

        [SerializeField]
    GameObject collidingObject = null;
    bool carryingObject;
    private bool slope;
    public GameObject PickUp_EGO;
    public bool isThrowing;
    private GameObject target;
    public float moveSpeed = 1f;
   
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    //--------------------------------
    public bool playerCanPickUp;

    public GameObject obstical1;
    public GameObject DropItem1;



    //public CharacterJoint handJoint;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
        if (instance != null)
        {
            Debug.Log("Badthing2");
        }

        else
        {
            instance = this;
        }
    }



    private void Update()

    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, (moveSpeed / 5f));



        }

        if (CompareTag("Slope"))
        {
            slope = true;
        }
        else
        {
            slope = false;
        }


        if (Input.GetKeyDown(KeyCode.E) && slope == false && collidingObject != null)
        {
            if (carryingObject)
            {
                Drop();
            }
            else
            {
                pickUp(collidingObject);
            }

        }

        if (carryingObject == true && Input.GetKeyDown(KeyCode.T))
        {
            Throw();

            /* Movement.instance.BurdenIsTrue();
             GetComponent<Rigidbody>().isKinematic = false;
             GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 200, throwSpeed));         
             Drop();
             Movement.instance.BurdenIsFalse();
             Debug.Log("Throw");*/
        }

        if (Movement.instance.throwForceRight == true)
        {
            throwSpeed = 0;
        }

        else if (Movement.instance.throwForceRight == false)
        {
            throwSpeed = -0;
        }



    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collidingObject = PickUp_EGO;
            Debug.Log("Player Entered Object");
        }

        if (other.CompareTag("Pick_Up_Drop_Zone"))
        {
            obstical1.SetActive(true);
            DropItem1.SetActive(false);
            Target_Practise.instance.KillPlusOne();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == collidingObject && !carryingObject)
        {
            collidingObject = null;
            Debug.Log("Player Left object");
        }
    }


    /*  void pickUp(GameObject newParent)
      {
          carryingObject = true;
        transform.parent = newParent.transform;

      }*/

    void pickUp(GameObject t)
    {
        target = t;
        carryingObject = true;
        // transform.parent = newParent.transform;
        //transform.position = target.transform.position;
        GetComponent<Rigidbody>().isKinematic = true;
       // GetComponent<Rigidbody>().useGravity = false;
        

        if (!source.isPlaying) {
            float vol = Random.Range(volLowRange, volHighRange);
            
        }
    }


    public void Drop()
    {
        target = null;
        carryingObject = false;
        transform.parent = null;
        Debug.Log("DropWorksButNah");
       GetComponent<Rigidbody>().isKinematic = false;
       // GetComponent<Rigidbody>().useGravity = true;
        

      

    }

    public void Throw() //Throw
    {
        // Movement.instance.BurdenIsFalse();
        GetComponent<Rigidbody>().isKinematic = false;
       // GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 25, throwSpeed));

        if (!source.isPlaying)
        {
            float vol = Random.Range(volLowRange, volHighRange);
            
        }




        // GetComponent<Rigidbody>().position -= transform.forward * Time.deltaTime * throwSpeed;
        Drop();
            
            Debug.Log("Throw");
    }
}