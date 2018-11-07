using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public AudioMixer audioMixer;

    public void MusicSetVolume (float volume)
    {
        audioMixer.SetFloat("Music_Vol", volume);
    }
    AudioSource m_MyAudioSource;
    //Value from the slider, and it converts to volume level
    //public Slider.va m_MySlider;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //Initiate the Slider value to half way
        //m_MySlider = 0.5f;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        m_MyAudioSource.Play();

    }

    void Update()
    {
        //Makes the volume of the Audio match the Slider value
        //m_MyAudioSource.volume = m_MySlider;
    }

}
