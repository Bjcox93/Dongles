using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up_Drop_Zone : MonoBehaviour {

    public GameObject EndPortal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick_Up_Drop_Zone"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Coffee_Released");
            EndPortal.gameObject.SetActive(true);

        }
    }
}
