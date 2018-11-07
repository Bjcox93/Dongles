using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Movement : MonoBehaviour
{
    public static Movement instance;

    public GameObject PlayerObject;

    Dictionary<string, float> movementSpeeds = new Dictionary<string, float>();

    public string speed;

    private float actualSpeed = 7f;

    public Material BlackMaterial;

    public Material WhiteMaterial;

    public Renderer Myrenderer;


    private Rigidbody playerRb;

    public bool facingRight;

    public bool turning;

    public float fallMultiplier = 2.5f;

    public float lowJumpMultiplier = 2f;

    [SerializeField]
    private float jumpForce;

    public bool throwForceRight;

    bool isGrounded = true;

    //AUDIO

    public AudioClip WalkSound;
    public AudioClip jumpSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    bool movementAllowed = true;

    //-----------------------------------------
    public bool playerActive;
    public GameObject MicePlayer;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.Log("Badthing3");
        }

        else
        {
            instance = this;
        }
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        SetUpMovementSpeeds();
        playerRb = GetComponent<Rigidbody>();

        speed = "walk";

        throwForceRight = true;

        playerActive = true;

        MicePlayer.gameObject.SetActive(true);



    }

    void SetUpMovementSpeeds()
    {
        movementSpeeds["walk"] = 6f;
        movementSpeeds["run"] = 15f;
    }

    // Update is called once per frame
    void Update()
    {


        if (!turning)
        {
            //Character walking


            if (Input.GetKeyDown(KeyCode.RightArrow) && playerActive == true)
            {
                if (facingRight)
                {
                    StartCoroutine(turn());
                    float vol = Random.Range(volLowRange, volHighRange);
                    source.PlayOneShot(WalkSound, vol);
                }
                facingRight = false;
                Camera_Horizon.instance.MoveCameraForwardTrue();
                Camera_Horizon.instance.MoveCameraBackFalse();

            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow) && playerActive == true)
            {
                if (!facingRight)
                {
                    StartCoroutine(turn());
                    float vol = Random.Range(volLowRange, volHighRange);
                    source.PlayOneShot(WalkSound, vol);

                }
                facingRight = true;
                Camera_Horizon.instance.MoveCameraBackTrue();
                Camera_Horizon.instance.MoveCameraForwardFalse();

            }






            //Run/Walk
            if ((Input.GetKeyDown(KeyCode.R)) && (isGrounded) && ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow))))
            {
                speed = "run";
                Debug.Log("Run");

            }

            else if (Input.GetKeyUp(KeyCode.R))
            {
                speed = "walk";
            }

            //Grab Burden

            //jumping
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded && playerActive == true)
            {
                isGrounded = false;
                playerRb.AddForce(Vector3.up * jumpForce);
                Debug.Log("Jump");
                float vol = Random.Range(volLowRange, volHighRange);
                source.PlayOneShot(jumpSound, vol);

            }

        }
    }

    public void ChangeMovementState(bool state)
    {
        movementAllowed = state;
    }

    private void FixedUpdate()
    {
        if (movementAllowed && playerActive == true)
        {
            this.gameObject.transform.position += Vector3.forward * Input.GetAxis("Horizontal") * movementSpeeds[speed] * Time.deltaTime;

            if (Input.GetAxis("Horizontal") != 0 && !source.isPlaying)
            {
                float vol = Random.Range(volLowRange, volHighRange);
                source.PlayOneShot((WalkSound), vol);

            }


            //right run speed at /24 wrong walk speed;







            if (playerRb.velocity.y < 0)
            {
                playerRb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }

            else if (playerRb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                playerRb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }


    }


    //Turning
    IEnumerator turn()
    {
        turning = true;
        int amount = 1;
        int i = 0;
        if (facingRight)
        {
            throwForceRight = true;
            Debug.Log("Right");
            while (i < amount)
            {
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 180, 0);
                i++;
            }
        }
        else
        {
            throwForceRight = false;
            Debug.Log("Left");
            while (i < amount)
            {
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 180, 0);
                i++;
            }
        }
        turning = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Player" && Input.GetKey(KeyCode.UpArrow))
        {
            playerActive = false;

            MicePlayer.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Player")
        {
            Myrenderer.material = BlackMaterial;
        }


        if (gameObject.tag == ("Pick Up") && Input.GetKeyDown(KeyCode.UpArrow))
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.parent = PlayerObject.transform;
        }

        if (gameObject.tag == ("Pick Up") && Input.GetKeyDown(KeyCode.DownArrow))
        {
            other.gameObject.SetActive(true);
            other.gameObject.transform.parent = null;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            Myrenderer.material = WhiteMaterial;
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //Voice Recognition;

    //Voice Move in direction;
    public void VoiceWalk()
    {
        if (movementAllowed && playerActive == true)
        {
            this.gameObject.transform.position += Vector3.forward * Input.GetAxis("Horizontal") * movementSpeeds[speed] * Time.deltaTime;

            if (Input.GetAxis("Horizontal") != 0 && !source.isPlaying)
            {
                float vol = Random.Range(volLowRange, volHighRange);
                source.PlayOneShot((WalkSound), vol);

            }
        }
    }

    //Voice Recognition Jump;
    public void VoiceJump()
    {
        playerRb.AddForce(Vector3.up * jumpForce);
    }

    //Voice Recognition Turn Left or Right;
    public void VoiceTurn()
    {
        turn();
    }

    //Voice Recognition Get in Tank;
    public void VoiceInTank()
    {
        if (gameObject.tag == "Player")
        {
            playerActive = false;

            MicePlayer.gameObject.SetActive(false);
        }
    }

}


//float speed = -0.000008f * Mathf.Pow(Intensity.instance.LightIntensity.intensity, 4) + 6;
//gameObject.transform.position = new Vector3(speed* Time.deltaTime,0);