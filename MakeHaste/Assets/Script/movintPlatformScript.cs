using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movintPlatformScript : MonoBehaviour {
	private float posneg = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.z >= 3) {
			posneg = -1f;
		} else if (transform.position.z <= -3) {
			posneg = 1f;
		}
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + posneg * 0.1f); 
			
//		foreach (Transform child in transform) {
//			if (child.tag == "movingPlatform") {
//				child.transform.position(
//			}
//		}
	}
}
