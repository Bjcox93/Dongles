using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Mouse_Hover : MonoBehaviour {

    public GameObject Start;
    public GameObject Continue;
    public GameObject Options;
    public GameObject Exit;
    public AudioClip SmallClick;
    public AudioSource AudioSource;


    public void Update()
    {
        int layerMask = 1 << 9;
        RaycastHit hit;
        AudioSource = GetComponent<AudioSource>();

        //Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, layerMask))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();
            rend.material.color = Color.black;

            //NOT SELECTED;
            Renderer rend2 = Start.gameObject.transform.GetComponent<Renderer>();
            Renderer rend3 = Continue.gameObject.transform.GetComponent<Renderer>();
            Renderer rend4 = Options.gameObject.transform.GetComponent<Renderer>();
            Renderer rend5 = Exit.gameObject.transform.GetComponent<Renderer>();

            //print("Found an object - distance: ");

            Debug.Log(hit.transform.gameObject.name);

            if (hit.transform.tag == "StartBlock")
            {
                Debug.Log("StartBlockHit");
                rend.material.color = Color.black;
                rend3.material.color = Color.white;
                rend4.material.color = Color.white;
                rend5.material.color = Color.red;
                AudioSource.PlayOneShot(SmallClick, 0.5f);
            }

            if (hit.transform.tag == "ContinueBlock")
            {
                Debug.Log("ContinueBlockHit");
                rend.material.color = Color.black;
                rend2.material.color = Color.red;
                rend4.material.color = Color.white;
                rend5.material.color = Color.red;
                AudioSource.PlayOneShot(SmallClick, 0.5f);
            }

            if (hit.transform.tag == "OptionsBlock")
            {
                Debug.Log("OptionsBlockHit");
                rend.material.color = Color.black;
                rend2.material.color = Color.red;
                rend3.material.color = Color.white;
                rend5.material.color = Color.red;
                AudioSource.PlayOneShot(SmallClick, 0.5f);
            }

            if (hit.transform.tag == "ExitBlock")
            {
                Debug.Log("ExitBlockHit");
                rend.material.color = Color.black;
                rend2.material.color = Color.red;
                rend3.material.color = Color.white;
                rend4.material.color = Color.white;
                AudioSource.PlayOneShot(SmallClick, 0.5f);
            }
            /* if (hit.transform.tag != "StartBlock")
             {
                 Debug.Log("StartBlockNotHit");
                 rend.material.color = Color.red;
             }*/
        }

        

        /*if(hit.transform.tag == "StartBlock")
        {

        }*/



        else { return; }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /* Renderer colourChange;

     private void Awake()
     {
         colourChange = GetComponent<Renderer>();
     }

     private void OnMouseDown()
     {
         if (UI_overlay.IsPointerOverUIObject())
         {
             colourChange.material.color = Color.black;
         }
     }*/
}
