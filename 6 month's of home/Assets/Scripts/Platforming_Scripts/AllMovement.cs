using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMovement : MonoBehaviour {


    Dictionary<string, float> movementSpeeds = new Dictionary<string, float>();

    public string speed;

    private float actualSpeed = 6f;

    private bool burden;

    private Rigidbody playerRb;

    public bool facingRight;

    public bool turning;

    public float fallMultiplier = 2.5f;

    public float lowJumpMultiplier = 2f;
    public float throwSpeed;

    [SerializeField]
    GameObject collidingObject = null;
    bool carryingObject;
    private bool slope;
    public GameObject PickUp_EGO;


    [SerializeField]
    private float jumpForce;

    private GameObject pickedUpItem;
    public GameObject PickedUpItem
    {
        get
        {
            return pickedUpItem;
        }
        set
        {
            pickedUpItem = value;
            // whenever the value is changed, do this.
            if (pickedUpItem != null)
            {
                actualSpeed = 1f;
                jumpForce = 200f;
                throwSpeed = throwSpeed / 2;
            }
            else
            {
                actualSpeed = 6f;
                jumpForce = 400f;
                throwSpeed = throwSpeed * 2;
            }
        }
    }

    bool isGrounded = true;
    //AUDIO

    public AudioClip jumpSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    bool movementAllowed = true;
    //-----------------------------------------

  

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                collidingObject = PickUp_EGO;
                Debug.Log("Player Entered Object");
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

 

}
