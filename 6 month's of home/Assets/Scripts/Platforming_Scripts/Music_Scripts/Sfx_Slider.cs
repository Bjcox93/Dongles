using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sfx_Slider : MonoBehaviour {

    public Slider sfxSlider;

    public void SubmitSliderSetting()
    {
        AudioManager.musicVolume = sfxSlider.value;
        Debug.Log(sfxSlider.value);
    }

	// Use this for initialization
	void Start () {
        sfxSlider.value = Audio_On_Collision.sfxVolume;
    }
	
	// Update is called once per frame
	void Update () {
        Audio_On_Collision.sfxVolume = sfxSlider.value;
    }
}
