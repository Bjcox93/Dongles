using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround1 : MonoBehaviour {

    public static MoveGround1 instance;

    public Transform target;
    public GameObject targetGO;

    public Transform target2;
    public GameObject target2GO;

    public bool Target1On;
    public bool Target2On;

    public bool BrumSaid;

    public AnimationCurve floorHeightCurve;
    public List<GameObject> floorBlocks;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("fuck_V3");
        }
        else
        {
            instance = this;
        }

        targetGO.SetActive(false);
        target2GO.SetActive(true);
        BrumSaid = false;
    }

    // Update is called once per frame
    void Update() {

        //Target1

        if (Input.GetKeyDown(KeyCode.N)) {
            targetGO.SetActive(true);
            target2GO.SetActive(false);
            for (int i = 0; i < floorBlocks.Count; i++)
            {
                Vector3 pos = floorBlocks[i].transform.position;
                float dist = Vector3.Distance(pos, target.position);

                pos.y = floorHeightCurve.Evaluate(dist / 50);
                floorBlocks[i].transform.position = pos;
            }
        }

        //Target2

        if (Input.GetKeyUp(KeyCode.N))
        {
            targetGO.SetActive(false);
            target2GO.SetActive(true);
            for (int i = 0; i < floorBlocks.Count; i++)
            {
                Vector3 pos = floorBlocks[i].transform.position;
                float dist = Vector3.Distance(pos, target2.position);

                pos.y = floorHeightCurve.Evaluate(dist / 50);
                floorBlocks[i].transform.position = pos;
            }
        }

    }

    public void BrumHappen()
    {
        if (BrumSaid == true)
        {
            targetGO.SetActive(true);
            target2GO.SetActive(false);
            for (int i = 0; i < floorBlocks.Count; i++)
            {
                Vector3 pos = floorBlocks[i].transform.position;
                float dist = Vector3.Distance(pos, target.position);

                pos.y = floorHeightCurve.Evaluate(dist / 50);
                floorBlocks[i].transform.position = pos;
            }
           
        }

        //Target2

        else if (BrumSaid == false)
        {
            targetGO.SetActive(false);
            target2GO.SetActive(true);
            for (int i = 0; i < floorBlocks.Count; i++)
            {
                Vector3 pos = floorBlocks[i].transform.position;
                float dist = Vector3.Distance(pos, target2.position);

                pos.y = floorHeightCurve.Evaluate(dist / 50);
                floorBlocks[i].transform.position = pos;
            }
            
        }

    }
}



