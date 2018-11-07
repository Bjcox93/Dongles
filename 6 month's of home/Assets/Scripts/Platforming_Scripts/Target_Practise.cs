using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Practise : MonoBehaviour {

    public static Target_Practise instance;

    public GameObject EndlevelGO;
    public int LetterKillCount;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Badthing3");
        }

        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        //EndlevelGO.SetActive(false);
         LetterKillCount = 0;
}
	
	// Update is called once per frame
	void Update () {
        if (LetterKillCount == 5)
        {
           // EndlevelGO.SetActive(true);
        }
    }

    public void FiveTargetsKilled()
    {
        EndlevelGO.SetActive(true);
    }

    public void KillPlusOne()
    {
        LetterKillCount++;
    }
}
