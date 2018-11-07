using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class Letter_Identifier2 : MonoBehaviour {
    //public static Letter_Identifier2 instance;
    public string prevAnimationString = "";
    public int animationGroupInt;
    public string animaitonStringGroupNumbers;
    public static readonly List<char[]> phonemes = new List<char[]>
    {
        new char[]{ },
        new char[]{'a', 'i'}, //group 1
        new char[]{'e'},//group 2
        new char[]{'u'},//group 3
        new char[]{'o'},//group 4
        new char[]{'c', 'd', 'g', 'k', 'n', 'r', 's','t', 'x', 'y', 'z', '~'},//group 5, ~ = th for now TODO
        new char[]{'f', 'v'},//group 6
        new char[]{'l'},//group 7
        new char[]{'m', 'b', 'p', 'h'},//group 8
        new char[]{'w','q'} //group 9
    };

	// Use this for initialization
	void Awake () {
        /* //string animationString = "make me";
         string animationString = V_Cog_Redo_V2.instance.AnimationString; //string animationString = "make maze and manage to the good of man";

         dumbAnimationScriptForCube.animationNums = CreatePhonemeAnimationList(animationString);*/

       /* if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }*/
    }

    List<int> CreatePhonemeAnimationList(string animationString)
    {
        List<int> animations = new List<int>();
        foreach (char ch in animationString)
        {
            for (int i = 1; i < phonemes.Count; i++)
            {
                foreach (char ph in phonemes[i])
                {
                    if (ph == ch)
                    {
                        animations.Add(i);
                        animaitonStringGroupNumbers += i.ToString();
                    }
                }
            }
        }
        print("Matching Letters:");
        foreach (int i in animations)
        {
            print(i);
        }
        return animations;
    }

    void PhonemeToAnimation()
    {
        switch (animationGroupInt)
        {
            case 9:
                Debug.Log("Group 9 animation play");
                break;

            case 8:
                Debug.Log("Group 8 animation play");
                break;

            case 7:
                Debug.Log("Group 7 animation play");
                break;

            case 6:
                Debug.Log("Group 6 animation play");
                break;

            case 5:
                Debug.Log("Group 5 animation play");
                break;

            case 4:
                Debug.Log("Group 4 animation play");
                break;

            case 3:
                Debug.Log("Group 3 animation play");
                break;

            case 2:
                Debug.Log("Group 2 animation play");
                break;

            case 1:
                Debug.Log("Group 1 animation play");
                break;
        }
    }
    /*
     *  //Group 1 (A,I)
        ShowMatch(str, @"\b\S*a\S*\b"); 
        ShowMatch(str, @"\b\S*i\S*\b");

        //Group 2 (E)
        ShowMatch(str, @"\b\S*e\S*\b");

        //Group 3 (U)
        ShowMatch(str, @"\b\S*u\S*\b");

        //Group 4 (O)
        ShowMatch(str, @"\b\S*o\S*\b");

        //Group 5 (C, D, G, K, N, R, S, Th, Y, and Z)
        ShowMatch(str, @"\b\S*c\S*\b");
        ShowMatch(str, @"\b\S*d\S*\b");
        ShowMatch(str, @"\b\S*g\S*\b");
        ShowMatch(str, @"\b\S*k\S*\b");
        ShowMatch(str, @"\b\S*n\S*\b");
        ShowMatch(str, @"\b\S*r\S*\b");
        ShowMatch(str, @"\b\S*s\S*\b");
        ShowMatch(str, @"\b\S*th\S*\b");
        ShowMatch(str, @"\b\S*y\S*\b");
        ShowMatch(str, @"\b\S*z\S*\b");

        //Group 6 (F, V)
        ShowMatch(str, @"\b\S*f\S*\b");
        ShowMatch(str, @"\b\S*v\S*\b");

        //Group 7 (L)
        ShowMatch(str, @"\b\S*l\S*\b");

        //Group 8 (M, B and P)
        ShowMatch(str, @"\b\S*m\S*\b");
        ShowMatch(str, @"\b\S*b\S*\b");
        ShowMatch(str, @"\b\S*p\S*\b");

        //Group 9 (W and Q)
        ShowMatch(str, @"\b\S*w\S*\b");
        ShowMatch(str, @"\b\S*q\S*\b");
     */
    private void Update()
    {

      string animationString = V_Cog_Redo_V3.instance.AnimationString;
        //string animationString = "my name is";
        if (prevAnimationString != animationString)
        {
            print("prevAnimationString: " + prevAnimationString);
            print("animationString: " + animationString);
            prevAnimationString = animationString;
            dumbAnimationScriptForCube.animationNums = CreatePhonemeAnimationList(animationString);
        }

        //Contains keywords/sentences Both work;
        if (animationString.Contains("name"))
        {
            //Debug.Log("what is your name?");
        }

        if (animationString.Contains("my name is"))
        {
            Debug.Log("what is your name?");
        }
    }
}
