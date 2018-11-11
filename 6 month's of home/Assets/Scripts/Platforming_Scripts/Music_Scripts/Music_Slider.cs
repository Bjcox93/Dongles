using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Slider : MonoBehaviour {

    public Slider musicSlider;

    public void SubmitSliderSetting()
    {
        AudioManager.musicVolume = musicSlider.value;
        Debug.Log(musicSlider.value);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AudioManager.musicVolume = musicSlider.value;
    }
}
