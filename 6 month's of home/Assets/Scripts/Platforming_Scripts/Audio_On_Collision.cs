using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_On_Collision : MonoBehaviour {

   public static Audio_On_Collision instance;

   public void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Badthing2");
        }

        else
        {
            instance = this;
        }

    }

    // Use this for initialization
    public AudioClip Boop;    // Add your Audi Clip Here;
                              // This Will Configure the  AudioSource Component; 
                              // MAke Sure You added AudioSouce to death Zone;
    public static float sfxVolume = 0.5f;

    //----------------------------------------------------------------------------
    //ScreenShake;
    public Screen_Shake Screen_Shake;
    public float duration = 0.2f; 

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = Boop;
    }

     void Update()
    {
        GetComponent<AudioSource>().volume = sfxVolume;
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
        Screen_Shake.Shake(duration);
    }
}
