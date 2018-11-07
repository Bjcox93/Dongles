using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dumbAnimationScriptForCube : MonoBehaviour {
    public static List<int> animationNums;
    public Animator m_Animator;
    public int AnimationSpeed;

    bool animationPlaying;
    
	// Use this for initialization
	void Start () {
        //StartCoroutine(AnimateMount(animationNums));
        m_Animator = GetComponent<Animator>();
        m_Animator.speed = AnimationSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        if (animationNums != null && animationPlaying == false)
        {
            StartCoroutine(AnimateMouth());
        }

       

        /*if (animationNums != null && animationPlaying == false && Letter_Identifier2.instance.prevAnimationString != V_Cog_Redo_V2.instance.AnimationString)
        {
            StartCoroutine(AnimateMouth());
        }*/
    }

    public IEnumerator AnimateMouth()
    {
        animationPlaying = true;
        foreach(int i in animationNums)
        {
            //Wait for secounds increase, increases the time to the error;
            yield return new WaitForSeconds(0.1f);
            //transform.localScale = new Vector3(1, i, 1);
            //m_Animator.Play("Rest");
            switch (i)
            {
                case 1:
                    //m_Animator.Play("Phoneme_A,I");//Group_1;
                    m_Animator.CrossFade("Phoneme_A,I", 0.1f);

                    Debug.Log("PLAY G1");
                    break;
                case 2:
                    //m_Animator.Play("Phoneme_E");//Group_2;
                    m_Animator.CrossFade("Phoneme_E", 0.1f);
                    Debug.Log("PLAY G2");
                    break;
                case 3:
                    //m_Animator.Play("Phoneme_U");//Group_3;
                    m_Animator.CrossFade("Phoneme_U", 0.1f);
                    Debug.Log("PLAY G3");
                    break;
                case 4:
                    //m_Animator.Play("Phoneme_O");//Group_4;
                    m_Animator.CrossFade("Phoneme_O", 0.1f);
                    Debug.Log("PLAY G4");
                    break;
                case 5:
                    //m_Animator.Play("Phoneme_C,D,G,K,N,R,S,T,H,Y,Z");//Group_5;
                    m_Animator.CrossFade("Phoneme_C,D,G,K,N,R,S,T,H,Y,Z", 0.1f);
                    Debug.Log("PLAY G5");
                    break;
                case 6:
                    //m_Animator.Play("Phoneme_F,V");//Group_6;
                    m_Animator.CrossFade("Phoneme_F,V", 0.1f);
                    Debug.Log("PLAY G6");
                    break;
                case 7:
                    //m_Animator.Play("Phoneme_L");//Group_7;
                    m_Animator.CrossFade("Phoneme_L", 0.1f);

                    Debug.Log("PLAY G7");
                    break;
                case 8:
                    //m_Animator.Play("Phoneme_W,Q");//Group_8;
                    m_Animator.CrossFade("Phoneme_W,Q", 0.1f);

                    Debug.Log("PLAY G8");
                    break;
                case 9:
                    //m_Animator.Play("Phoneme_M,B,P");//Group_9;
                    m_Animator.CrossFade("Phoneme_M,B,P", 0.1f);

                    Debug.Log("PLAY G9");
                    break;
                default:
                    break;
            }
            /*
            if (i==1)
            {
                m_Animator.Play("Phoneme_A,I");//Group_1;
                Debug.Log("PLAY G1");
            }

            if (i==2)
            {
                m_Animator.Play("Phoneme_E");//Group_2;
                Debug.Log("PLAY G2");
            }

            if (i==3)
            {
                m_Animator.Play("Phoneme_U");//Group_3;
                Debug.Log("PLAY G3");
            }

            if (i==4)
            {
                m_Animator.Play("Phoneme_O");//Group_4;
                Debug.Log("PLAY G4");
            }

            if (i==5)
            {
                m_Animator.Play("Phoneme_C,D,G,K,N,R,S,T,H,Y,Z");//Group_5;
                Debug.Log("PLAY G4");
            }

            if (i==6)
            {
                m_Animator.Play("Phoneme_F,V");//Group_6;
                Debug.Log("PLAY G5");
            }

            if (i==7)
            {
                m_Animator.Play("Phoneme_L");//Group_7;
                Debug.Log("PLAY G6");
            }

            if (i==8)
            {
                m_Animator.Play("Phoneme_W,Q");//Group_8;
                Debug.Log("PLAY G7");
            }

            if (i==9)
            {
                m_Animator.Play("Phoneme_M,B,P");//Group_9;
                Debug.Log("PLAY G8");
            }

            else if(i<1||i>9)
            {
                m_Animator.Play("Rest");//Group_Null;
                Debug.Log("PLAY REST");
            }
            */
            // m_Animator.Play("Phoneme_A,I");//Group_1;
            // m_Animator.Play("Phoneme_U");//Group_3;
            // m_Animator.Play("Phoneme_O");//Group_4;
            //m_Animator.Play("Phoneme_F,V");//Group_6;
            //m_Animator.Play("Phoneme_L");//Group_7;
            // m_Animator.Play("Phoneme_C,D,G,K,N,R,S,T,H,Y,Z");//Group_5;
            //m_Animator.Play("Phoneme_M,B,P");//Group_9;
            // m_Animator.Play("Phoneme_W,Q");//Group_8;
            // m_Animator.Play("Phoneme_E");//Group_2;
        }
        animationNums = null;
        //m_Animator.Play("Rest");//Group_Null;
        m_Animator.CrossFade("Rest", 0.1f);
        Debug.Log("PLAY REST");
        animationPlaying = false;
    }
   
}
