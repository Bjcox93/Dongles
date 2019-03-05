using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance = null;

    public AudioMixer audioMixer;
    public static float musicVolume = 0.5f;
    

    public float audioJump1f = 20f;
    public AudioClip _AudioClip0; //Menus
    public AudioClip _AudioClip1; //Level 1
    public AudioClip _AudioClip2; //Level 2
    public AudioClip _AudioClip3; //Level 3
    public AudioClip _AudioClip4; //Level 4
    public AudioClip _AudioClip5; //Level 5
    public AudioClip _AudioClip6; //Level 6
    public AudioClip _AudioClip7; //Level 7
    public AudioClip _AudioClip8; //Level 8
    public AudioClip _AudioClip9; //Level 9
    public AudioClip _AudioClip10; //Level 10
    public AudioClip _AudioClip11; //Level 11
    //public AudioClip _AudioClip2;

    public void MusicSetVolume (float volume)
    {
        audioMixer.SetFloat("Music_Vol", volume);
    }
    public AudioSource m_MyAudioSource;
    //Value from the slider, and it converts to volume level
    //public Slider.va m_MySlider;

    void Start()
    {
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Debug.Log("Hi");
        DontDestroyOnLoad(this.gameObject);
        //Initiate the Slider value to half way
        //m_MySlider = 0.5f;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        m_MyAudioSource.Play();
        m_MyAudioSource.clip = _AudioClip0;

    }

    void Update()
    {
        //Makes the volume of the Audio match the Slider value
        m_MyAudioSource.volume = musicVolume;
    }
    public void PlayLvl1Music()
    {
        m_MyAudioSource.clip = _AudioClip1;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl2Music()
    {
        m_MyAudioSource.clip = _AudioClip2;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl3Music()
    {
        m_MyAudioSource.clip = _AudioClip3;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl4Music()
    {
        m_MyAudioSource.clip = _AudioClip4;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl5Music()
    {
        m_MyAudioSource.clip = _AudioClip5;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl6Music()
    {
        m_MyAudioSource.clip = _AudioClip6;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl7Music()
    {
        m_MyAudioSource.clip = _AudioClip7;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl8Music()
    {
        m_MyAudioSource.clip = _AudioClip8;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl9Music()
    {
        m_MyAudioSource.clip = _AudioClip9;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl10Music()
    {
        m_MyAudioSource.clip = _AudioClip0;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }

    public void PlayLvl11Music()
    {
        m_MyAudioSource.clip = _AudioClip11;
        m_MyAudioSource.Pause();
        m_MyAudioSource.Play();
    }
}
