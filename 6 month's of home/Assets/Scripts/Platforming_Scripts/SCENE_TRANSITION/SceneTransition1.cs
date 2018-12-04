using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition1 : MonoBehaviour {

    public AudioClip EndBoop1;

    public string nextLevel = "LEVEL_3";

    //Scene transition
    public float waitTime = 3;
    public AnimationCurve buttonAnimationCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    // Time when the movement started.
    private float startTime;

    //Circle
    public GameObject BaseCircle;
    public GameObject SmallCircle;
    public GameObject BigCircle;

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = EndBoop1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForSceneTrans()
    {
        for (float t = 0; t < waitTime; t += Time.unscaledDeltaTime)
        {
            float progression = buttonAnimationCurve.Evaluate(t / waitTime);
            BaseCircle.transform.localScale = Vector3.Lerp(SmallCircle.transform.localScale, BigCircle.transform.localScale, progression);
            yield return new WaitForEndOfFrame();
            GetComponent<AudioSource>().Play();
        }

        //GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("LEVEL_7");
        Debug.LogError(SceneManager.GetSceneByName(nextLevel).buildIndex);
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

        }
    }
}
