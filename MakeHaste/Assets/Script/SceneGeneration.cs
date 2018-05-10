using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGeneration : MonoBehaviour {
    [SerializeField] GameObject leftFence;
    [SerializeField] GameObject rightFence;
	[SerializeField] GameObject leftwall;
	[SerializeField] GameObject rightwall;

	[SerializeField] GameObject bgleft;
	[SerializeField] GameObject bgright;
	[SerializeField] GameObject floor;

	// Use this for initialization
	void Start () {
		for(int i = 30; i < 1000; i+=30)
        {
            GameObject nextLeft =  Instantiate(leftFence);
            GameObject nextRight = Instantiate(rightFence);
			GameObject nextbgLeft =  Instantiate(bgleft);
			GameObject nextbgRight = Instantiate(bgright);
			GameObject nextleftwall =  Instantiate(leftwall);
			GameObject nextrightwall = Instantiate(rightwall);

            nextLeft.transform.position = 
                new Vector3(i, leftFence.transform.position.y, leftFence.transform.position.z);
            nextRight.transform.position =
                new Vector3(i, rightFence.transform.position.y, rightFence.transform.position.z);
			nextbgLeft.transform.position =
				new Vector3(i, bgleft.transform.position.y, bgleft.transform.position.z);
			nextbgRight.transform.position =
				new Vector3(i, bgright.transform.position.y, bgright.transform.position.z);
			nextleftwall.transform.position =
				new Vector3(i, leftwall.transform.position.y, leftwall.transform.position.z);
			nextrightwall.transform.position =
				new Vector3(i, rightwall.transform.position.y, rightwall.transform.position.z);
			
        }

		for (int i = 50; i < 1000; i += 50) {
			GameObject nextfloor = Instantiate(floor);
			nextfloor.transform.position =
				new Vector3(i, floor.transform.position.y, floor.transform.position.z);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
