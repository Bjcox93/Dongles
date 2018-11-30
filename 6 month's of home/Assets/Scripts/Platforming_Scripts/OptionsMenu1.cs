using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu1 : MonoBehaviour {

    

    public GameObject MainMenuUI;

    //Lerp
    public GameObject MenuNewGO;
    public Transform TargetMenu_Start;
    public Transform TargetMenu_End;

    public GameObject ButtonMenuNewGO;
    public Transform ButtonTargetMenu_Start;
    public Transform ButtonTargetMenu_End;

    public float SpeedOfMove;

    //Lerp Bools
    public bool LerpMenu;

    // Use this for initialization
    void Start () {
        LerpMenu = false;
	}

    // Update is called once per frame
    public void Update()
    {
        if (LerpMenu == true)
        {
            MenuNewGO.transform.position = Vector3.Lerp(TargetMenu_Start.transform.position, TargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            ButtonMenuNewGO.transform.position = Vector3.Lerp(ButtonTargetMenu_Start.transform.position, ButtonTargetMenu_End.transform.position, SpeedOfMove * Time.deltaTime);
            SceneManager.LoadScene("Title_Menu");
        }
    }

    public void StartNew()
    {
        SceneManager.LoadScene("LEVEL_1");
    }

   

    public void MainMenu()
    {
        LerpMenu = true;
        //SceneManager.LoadScene("Title_Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("LEVEL_2");
    }

    public void Level2()
    {
        SceneManager.LoadScene("LEVEL_1");
    }

    public void Level3()
    {
        SceneManager.LoadScene("LEVEL_3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("LEVEL_4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("LEVEL_5");
    }
}
