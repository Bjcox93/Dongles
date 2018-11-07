using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class Letter_Identifier : MonoBehaviour {
    public int animationGroupInt;

	// Use this for initialization
	void Start () {
        string str = "make maze and manage to good it m235346e"; //string str = V_Cog_Redo_V2.instantiate.AnimationString;
        print("Matching words start with 'm' and with 'e':");
        //Group 1 (A,I)
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
    }

    // Update is called once per frame
    private static void ShowMatch(string text, string expr)
    {
        print("The Expression: " + expr);
        MatchCollection mc = Regex.Matches(text, expr);

        foreach (Match m in mc)
        {
            print(m);
 
        }

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
}
