using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class V_Cog_Redo : MonoBehaviour
{
    [SerializeField]
    public string[] keywords = new string[] { "up", "down", "left", "right" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;


    //public Text results;


    protected KeywordRecognizer recognizer;
    protected string word = "right";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        //word = args.text;
        //results.text = "You said: <b>" + word + "</b>";

        if (args.text == "up")
        {
            Debug.Log("up_said");
            Wolverine();
        }
    }

    private void Update()
    {


        /*switch (word)
        {
            case "up":
                Debug.Log("up");
                break;
            case "down":
                Debug.Log("down");
                break;
            case "left":
                Debug.Log("left");
                break;
            case "right":
                Debug.Log("right");
                break;
        }*/


    }

    public void Wolverine()
    {
        Debug.Log("up_said_and_Function_working");
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
