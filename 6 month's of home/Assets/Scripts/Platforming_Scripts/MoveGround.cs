using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour {

    public Transform target;
    public AnimationCurve floorHeightCurve;
    public List<GameObject> floorBlocks;

	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i <floorBlocks.Count; i++)
        {
            Vector3 pos = floorBlocks[i].transform.position;
            float dist = Vector3.Distance(pos, target.position);

            pos.y = floorHeightCurve.Evaluate(dist / 10);
            floorBlocks[i].transform.position = pos;
        }
	}
}
