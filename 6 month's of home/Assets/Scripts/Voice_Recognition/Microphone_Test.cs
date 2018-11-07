using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Microphone_Test : MonoBehaviour {

    public float AudioVolume = 0.5f;
	// Use this for initialization
	void Start () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.volume = AudioVolume;
        audio.clip = Microphone.Start(null, true, 1, 22050);
        audio.loop = true;
        while (!(Microphone.GetPosition(null) > 1000)) { }
        Debug.Log("start playing... position is " + Microphone.GetPosition(null));
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
