using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_movement : MonoBehaviour
{
    public GameObject TankGameObject;

    public GameObject EmptyTank;
    public Vector3 TankPos;

    public float speed;

    private Rigidbody Tankrb;

    void Start()
    {
        Tankrb = GetComponent<Rigidbody>();
        EmptyTank = GameObject.Find("Empty");
        //TankPos = EmptyTank.transform.position;
    }

    void FixedUpdate()
    {
        if (Movement.instance.playerActive == false) {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //Tankrb.AddForce(movement * speed);
            Vector3 dirVector = (Vector3.forward * Input.GetAxis("Horizontal") * speed * Time.deltaTime).normalized;
            GetComponent<Rigidbody>().MovePosition(transform.position + dirVector * Time.deltaTime);
            Movement.instance.MicePlayer.transform.parent = TankGameObject.transform;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow) && Movement.instance.playerActive == false)
        {
            Movement.instance.playerActive = true;
            Movement.instance.MicePlayer.gameObject.SetActive(true);
            Movement.instance.MicePlayer.transform.parent = null; 
        }
    }

    //--------------------------------------------------------------------------------------------------------------------
    //Voice Recognition Tank;

    //Voice Recognition Tank Move

    public void VoiceTankMove()
    {
        if (Movement.instance.playerActive == false)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //Tankrb.AddForce(movement * speed);
            Vector3 dirVector = (Vector3.forward * Input.GetAxis("Horizontal") * speed * Time.deltaTime).normalized;
            GetComponent<Rigidbody>().MovePosition(transform.position + dirVector * Time.deltaTime);
            Movement.instance.MicePlayer.transform.parent = TankGameObject.transform;
        }
    }

    public void VoiceTankOut()
    {
        if (Movement.instance.playerActive == false)
        {
            Movement.instance.playerActive = true;
            Movement.instance.MicePlayer.gameObject.SetActive(true);
            Movement.instance.MicePlayer.transform.parent = null;
        }
    }
   
}



