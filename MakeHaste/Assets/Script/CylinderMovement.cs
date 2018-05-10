using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour {


    //private Transform center;
    private float time;
    private float direction;
	// Use this for initialization
	void Start () {
        foreach (Transform child in transform)
        {
            if(child.tag == "Center")
            {
                //center = child.transform;
            }
        }
        direction = (int)Random.Range(0, 2);
        if (direction == 1)
            direction = -1f;
        else
            direction = 1f;
        time = Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime * 0.01f * direction;
		foreach (Transform child in transform)
        {
            if(child.tag == "Center")
            {
                child.Rotate(new Vector3(0, time, 0));
            }
        }
	}
}
