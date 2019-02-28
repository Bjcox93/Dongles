using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition7 : MonoBehaviour {


    public AudioClip EndBoop1;

    public string nextLevel = "LEVEL_11";

    //Scene transition
    public float waitTime = 3;
    public AnimationCurve buttonAnimationCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    // Time when the movement started.
    private float startTime;

    //Lines:
    public GameObject BaseLine1;
    public GameObject SmallLine1;
    public GameObject BigLine1;
    //________________________
    public GameObject BaseLine2;
    public GameObject SmallLine2;
    public GameObject BigLine2;
    //________________________
    public GameObject BaseLine3;
    public GameObject SmallLine3;
    public GameObject BigLine3;
    //________________________
    public GameObject BaseLine4;
    public GameObject SmallLine4;
    public GameObject BigLine4;

    public GameObject ParticalGrp;

    public Animator animator;
    public Animator animator2;

    //------------------------
    public bool EndLevel7;

    // Use this for initialization
    void Start()
    {
        Reset.instance.SceneTrans7 = this;
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = EndBoop1;
        ParticalGrp.SetActive(false);
        EndLevel7 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForSceneTrans()
    {
        for (float t = 0; t < waitTime; t += Time.unscaledDeltaTime)
        {
            FadeOut();
            Pendulum2.instance.GetBigger();
            //ParticalGrp.SetActive(true);
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            //BaseLine1.transform.position = Vector3.Lerp(SmallLine1.transform.position, BigLine1.transform.position, progression);
            //BaseLine2.transform.position = Vector3.Lerp(SmallLine2.transform.position, BigLine2.transform.position, progression);
            //BaseLine3.transform.position = Vector3.Lerp(SmallLine3.transform.position, BigLine3.transform.position, progression);
            //BaseLine4.transform.position = Vector3.Lerp(SmallLine4.transform.position, BigLine4.transform.position, progression);
            yield return new WaitForEndOfFrame();
            GetComponent<AudioSource>().Play();
        }

        //GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("LEVEL_11");
        //Debug.LogError(SceneManager.GetSceneByName(nextLevel).buildIndex);
        EndLevel7 = true;
        GameManager.instance.currentLevel = nextLevel;
        GameManager.instance.SaveGame();
        SceneManager.LoadScene(nextLevel);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tank"))
        {
            /*GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("LEVEL_7");
            Debug.LogError(SceneManager.GetSceneByName(nextLevel).buildIndex);
            GameManager.instance.currentLevel = nextLevel;
            GameManager.instance.SaveGame();
            SceneManager.LoadScene(nextLevel);*/

            //SceneTransition
            Time.timeScale = 0.2f;
            StartCoroutine(WaitForSceneTrans());
            EndLevel7 = true;

        }
    }
    public void FadeOut()
    {
        animator2.SetTrigger("Lines_Transition_Fix");
        animator.SetTrigger("FadeIn");
    }
}
