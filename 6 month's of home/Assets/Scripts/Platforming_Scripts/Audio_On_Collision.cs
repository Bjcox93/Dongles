using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_On_Collision : MonoBehaviour {

    // Use this for initialization
    public AudioClip Boop;    // Add your Audi Clip Here;
                              // This Will Configure the  AudioSource Component; 
                              // MAke Sure You added AudioSouce to death Zone;
    public static float sfxVolume = 0.5f;
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
    }
}
