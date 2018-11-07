using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Windows.Speech;

public class V_Cog_Redo_V3 : MonoBehaviour
{
    public static V_Cog_Redo_V3 instance;

    KeywordRecognizer keywordRecognizer;
    // keyword array
    public string[] Keywords_array;
    public UnityEngine.UI.Text text;
    //public ConfidenceLevel Confidence = ConfidenceLevel.Low;
    
    //Always set in editor as rejected;
    
    //public AudioClip OtherString;

    private AudioSource source;
    private float volLowRange = 0.5f;
    private float volHighRange = 1.0f;

    //Countdown too speak
   
    

    //Live animations
    public string AnimationString;

   


    private void Awake()
    {
        source = GetComponent<AudioSource>();
       // TimeToTalk();
       
       

        if (instance != null)
        {
            Debug.Log("fuck_V3");
        }
        else
        {
            instance = this;
        }
    

}
    // Use this for initialization
    void Start()
    {
        // Change size of array for your requirement
        Keywords_array = new string[100];
        Keywords_array[0] = "hello";
        Keywords_array[1] = "how are you";
        Keywords_array[2] = "test";
        Keywords_array[3] = "it works";
        Keywords_array[4] = "today";
        Keywords_array[5] = "i";
        Keywords_array[6] = "am";
        Keywords_array[7] = "fine";
        Keywords_array[8] = "exit";
        Keywords_array[9] = "close";
        Keywords_array[10] = "quit";
        Keywords_array[11] = "so";
        Keywords_array[12] = "fuck";
        Keywords_array[13] = "shit";
        Keywords_array[14] = "basterd";
        Keywords_array[15] = "amazing";
        Keywords_array[16] = "fantastic";
        Keywords_array[17] = "you";
        Keywords_array[18] = "was";
        Keywords_array[19] = "me";
        Keywords_array[20] = "my";
        Keywords_array[21] = "not";
        Keywords_array[22] = "dad";
        Keywords_array[23] = "father";
        Keywords_array[24] = "mom";
        Keywords_array[25] = "mum";
        Keywords_array[26] = "mother";
        Keywords_array[27] = "dreams";
        Keywords_array[28] = "dream";
        Keywords_array[29] = "myself";
        Keywords_array[30] = "yourself";
        Keywords_array[31] = "who";
        Keywords_array[32] = "where";
        Keywords_array[33] = "here";
        Keywords_array[34] = "guilty";
        Keywords_array[35] = "incorrect";
        Keywords_array[36] = "eat";
        Keywords_array[37] = "already";
        Keywords_array[38] = "annoy";
        Keywords_array[39] = "trying";
        Keywords_array[40] = "to";
        Keywords_array[41] = "recognise";
        Keywords_array[42] = "understand";
        Keywords_array[43] = "new";
        Keywords_array[44] = "out";
        Keywords_array[45] = "begin";
        Keywords_array[46] = "breaking";
        Keywords_array[47] = "entering";
        Keywords_array[48] = "criminal";
        Keywords_array[49] = "justice";
        Keywords_array[50] = "break";
        Keywords_array[51] = "don't";
        Keywords_array[52] = "her";
        Keywords_array[53] = "him";
        Keywords_array[54] = "hi";
        Keywords_array[55] = "they";
        Keywords_array[56] = "can't";
        Keywords_array[57] = "help";
        Keywords_array[58] = "did";
        Keywords_array[59] = "love";
        Keywords_array[60] = "hate";
        Keywords_array[61] = "crime";
        Keywords_array[62] = "treasure";
        Keywords_array[63] = "money";
        Keywords_array[64] = "zoom";
        Keywords_array[65] = "jail";
        Keywords_array[66] = "time";
        Keywords_array[67] = "years";
        Keywords_array[68] = "dream";
        Keywords_array[69] = "dreaming";
        Keywords_array[70] = "awaken";
        Keywords_array[71] = "awake";
        Keywords_array[72] = "awakening";
        Keywords_array[73] = "marvel";
        Keywords_array[74] = "earth";
        Keywords_array[75] = "comic";
        Keywords_array[76] = "world";
        Keywords_array[77] = "war";
        Keywords_array[78] = "kill";
        Keywords_array[79] = "killer";
        Keywords_array[80] = "killing";
        Keywords_array[81] = "are you feeling ok";
        Keywords_array[82] = "good";
        Keywords_array[83] = "yes";
        Keywords_array[84] = "yeah";
        Keywords_array[85] = "no";
        Keywords_array[86] = "nah";
        Keywords_array[87] = "do";
        Keywords_array[88] = "everyday";
        Keywords_array[89] = "hey";
        Keywords_array[90] = "red";
        Keywords_array[91] = "make";
        Keywords_array[92] = "bridge";
        Keywords_array[93] = "pontoon";
        Keywords_array[94] = "stop";
        Keywords_array[95] = "target";
        Keywords_array[96] = "ramp";
        Keywords_array[97] = "fire";
        Keywords_array[98] = "pop";
        Keywords_array[99] = "brum";


        // instantiate keyword recognizer, pass keyword array in the constructor
        keywordRecognizer = new KeywordRecognizer(Keywords_array,ConfidenceLevel.Low);
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        // start keyword recognizer
        keywordRecognizer.Start();


    }

    void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
       //------------------------------------------------------------------------------------------------------------------------------------------------------------
        Debug.Log("Keyword: " + args.text + "; Confidence: " + args.confidence + "; Start Time: " + args.phraseStartTime + "; Duration: " + args.phraseDuration);
        // write your own logic
        if (args.text == "hello" || args.text == "hey")
        {
      
            Wolverine();
            //--------------------------------------------------
            //Falling Hey:
            Instantiate_Alphabet.instance.MakeH();
            Instantiate_Alphabet.instance.MakeE();
            Instantiate_Alphabet.instance.MakeY();
        }

        if (args.text == "hello" || args.text == "hey" )
        {
            Debug.Log("Puff_Of_Smoke");
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "war" && args.text == "kill")
        {
            Cyclops();
            //multiple indivdual key words work
            Instantiate_Alphabet.instance.MakeW();
            Instantiate_Alphabet.instance.MakeA();
            Instantiate_Alphabet.instance.MakeR();

            Instantiate_Alphabet.instance.MakeK();
            Instantiate_Alphabet.instance.MakeI();
            Instantiate_Alphabet.instance.MakeL();
            Instantiate_Alphabet.instance.MakeL();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "don't" )
        {
            
            Beast();
            //Contraction swork
            Instantiate_Alphabet.instance.MakeD();
            Instantiate_Alphabet.instance.MakeO();
            Instantiate_Alphabet.instance.MakeN();
            Instantiate_Alphabet.instance.MakeT();
           
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "are you feeling ok")
        {
            Cyclops();
            
            print(AnimationString);
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "how are you")
        {
            Cyclops();
            
            //Sentences work


        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "good" )
        {
            
            //---------------------------------------------------------------------
            //Falling Good:
            Instantiate_Alphabet.instance.MakeG();
            Instantiate_Alphabet.instance.MakeO();
            Instantiate_Alphabet.instance.MakeO();
            Instantiate_Alphabet.instance.MakeD();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //synonyms:

        if (args.text == "yes" || args.text == "yeah" )
        {
            Instantiate_Alphabet.instance.MakeY();
            Instantiate_Alphabet.instance.MakeE();
            Instantiate_Alphabet.instance.MakeS();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "no" || args.text == "nah")
        {
            Instantiate_Alphabet.instance.MakeN();
            Instantiate_Alphabet.instance.MakeO();
            
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "red" )
        {
            Instantiate_Alphabet.instance.MakeR();
            Instantiate_Alphabet.instance.MakeE();
            Instantiate_Alphabet.instance.MakeD();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (args.text == "bridge")
        {
            
                Instantiate_Pontoon.instance.OpenBridge();
           
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "pontoon")
        {
           
                Instantiate_Pontoon.instance.MakePontoon();
           
           
            
        }

        if (args.text == "ramp")
        {
            Instantiate_Pontoon.instance.OpenRamp();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "stop")
        {
            Background_disintergration.instance.there=false;
            Background_disintergration.instance.back = true;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (args.text == "target")
        {
            Instantiate_Alphabet.instance.MakeT();
            Instantiate_Alphabet.instance.MakeA();
            Instantiate_Alphabet.instance.MakeR();
            Instantiate_Alphabet.instance.MakeG();
            Instantiate_Alphabet.instance.MakeE();
            Instantiate_Alphabet.instance.MakeT();
        }

        if (args.text == "fire")
        {
            Fire_Bullet.instance.voiceFire();
        }

        if (args.text == "pop")
        {
            //Make POP True;
            CannonRotate2.instance.PopSaid = true;
            CannonRotate2.instance.PopHappen();
            //Make POP False;
            CannonRotate2.instance.PopSaid = false;
            
            Debug.Log("POP_SAID");
        }

        if (args.text == "brum")
        {
            //Make BRUM True;
            MoveGround1.instance.BrumSaid = true;
            MoveGround1.instance.BrumHappen();
            //Make BRUM False;
            MoveGround1.instance.BrumSaid = false;
            
            Debug.Log("BRUM_SAID");
        }
    }

    public void Wolverine()
    {
        Debug.Log("Fuck me it worked...");
       
    }

    public void Cyclops()
    {
        Debug.Log("multiple words work");
    }

    public void Beast()
    {
        Debug.Log("Contractions work");
    }

    private void Update()
    {
      
    }
    /*public void TimeToTalk()
    {
        Debug.Log("TimerStarted");
        timeToSpeak -= Time.deltaTime;

        if (timeToSpeak < 0 && HostSpoken == false)
        {
            Debug.Log("Hello are you there?");
        }
    }*/
}