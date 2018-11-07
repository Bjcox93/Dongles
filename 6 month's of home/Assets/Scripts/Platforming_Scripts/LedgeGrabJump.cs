using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGrabJump : MonoBehaviour {

    public bool isGrabbing;
    public float jumpForce;
    public Rigidbody playerRigidBody;
    public Movement playerMovementScript;

    //AUDIO

        // JUMP_AUDIO
    public AudioClip grabSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    bool movementAllowed = true;

    // Use this for initialization

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void Start () {
        playerRigidBody = GetComponent<Rigidbody>();
        isGrabbing = false;
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space) && isGrabbing)
        {
            playerMovementScript.ChangeMovementState(true);
            playerRigidBody.isKinematic = false;
            isGrabbing = false;
            playerRigidBody.AddForce(new Vector3(0, 0.87f,-0.75f) * jumpForce);
            Debug.Log("Jump");

           // float vol = Random.Range(volLowRange, volHighRange);
           // source.PlayOneShot(jumpSound, vol);


        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrabbing)
        {
            playerMovementScript.ChangeMovementState(true);
            playerRigidBody.isKinematic = false;
            playerRigidBody.AddForce(new Vector3(0, -0.50f, -0.4f) * jumpForce / 2);
            Debug.Log("Drop");
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ledge"))
        {
            playerMovementScript.ChangeMovementState(false);
            isGrabbing = true;
            Debug.Log("grabledge");
            playerRigidBody.isKinematic = true;
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(grabSound, vol);
        }
    }
}
