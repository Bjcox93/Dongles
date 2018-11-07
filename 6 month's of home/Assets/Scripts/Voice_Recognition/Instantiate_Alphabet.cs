using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Alphabet : MonoBehaviour {
    public static Instantiate_Alphabet instance;

    public GameObject Letter_A;
    public GameObject Letter_B;
    public GameObject Letter_C;
    public GameObject Letter_D;
    public GameObject Letter_E;
    public GameObject Letter_F;
    public GameObject Letter_G;
    public GameObject Letter_H;
    public GameObject Letter_I;
    public GameObject Letter_J;
    public GameObject Letter_K;
    public GameObject Letter_L;
    public GameObject Letter_M;
    public GameObject Letter_N;
    public GameObject Letter_O;
    public GameObject Letter_P;
    public GameObject Letter_Q;
    public GameObject Letter_R;
    public GameObject Letter_S;
    public GameObject Letter_T;
    public GameObject Letter_U;
    public GameObject Letter_V;
    public GameObject Letter_W;
    public GameObject Letter_X;
    public GameObject Letter_Y;
    public GameObject Letter_Z;

    public int DropForce;

    // Use this for initialization
    public void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Alpha..beat");
        }
        else
        {
            instance = this;
        }
    }

    private void Update()
    {
       // MakeA();
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------
    public void MakeA()
    {
        GameObject LetterA = Instantiate(Letter_A, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterA.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeB()
    {
        GameObject LetterB = Instantiate(Letter_B, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterB.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeC()
    {
        GameObject LetterC = Instantiate(Letter_C, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterC.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeD()
    {
        GameObject LetterD = Instantiate(Letter_D, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterD.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeE()
    {
        GameObject LetterE = Instantiate(Letter_E, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterE.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeF()
    {
        GameObject LetterF = Instantiate(Letter_F, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterF.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeG()
    {
        GameObject LetterG = Instantiate(Letter_G, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterG.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeH()
    {
        GameObject LetterH = Instantiate(Letter_H, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterH.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeI()
    {
        GameObject LetterI = Instantiate(Letter_I, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterI.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeJ()
    {
        GameObject LetterJ = Instantiate(Letter_J, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterJ.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeK()
    {
        GameObject LetterK = Instantiate(Letter_K, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterK.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeL()
    {
        GameObject LetterL = Instantiate(Letter_L, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterL.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeM()
    {
        GameObject LetterM = Instantiate(Letter_M, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterM.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeN()
    {
        GameObject LetterN = Instantiate(Letter_N, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterN.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeO()
    {
        GameObject LetterO = Instantiate(Letter_O, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterO.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeP()
    {
        GameObject LetterP = Instantiate(Letter_P, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterP.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeQ()
    {
        GameObject LetterQ = Instantiate(Letter_Q, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterQ.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeR()
    {
        GameObject LetterR = Instantiate(Letter_R, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterR.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeS()
    {
        GameObject LetterS = Instantiate(Letter_S, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterS.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeT()
    {
        GameObject LetterT = Instantiate(Letter_T, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterT.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeU()
    {
        GameObject LetterU = Instantiate(Letter_U, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterU.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeV()
    {
        GameObject LetterV = Instantiate(Letter_V, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterV.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeW()
    {
        GameObject LetterW = Instantiate(Letter_W, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterW.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeX()
    {
        GameObject LetterX = Instantiate(Letter_X, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterX.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeY()
    {
        GameObject LetterY = Instantiate(Letter_Y, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterY.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }

    public void MakeZ()
    {
        GameObject LetterZ = Instantiate(Letter_Z, transform.position, transform.rotation * Quaternion.identity) as GameObject;
        LetterZ.GetComponent<Rigidbody>().AddForce(transform.forward * DropForce);
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------

    
}
