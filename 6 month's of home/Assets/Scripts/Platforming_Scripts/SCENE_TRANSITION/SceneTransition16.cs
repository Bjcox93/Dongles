using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition16 : MonoBehaviour {
    public AudioClip EndBoop1;

    public string nextLevel = "LEVEL_8";

    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = EndBoop1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tank"))
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("LEVEL_8");
            Debug.LogError (SceneManager.GetSceneByName (nextLevel).buildIndex);
			GameManager.instance.currentLevel = nextLevel;
            GameManager.instance.SaveGame();
            SceneManager.LoadScene(nextLevel);
            
        }
    }
    }
