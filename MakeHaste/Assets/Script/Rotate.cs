﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down * Time.deltaTime * 15);
		transform.Rotate(Vector3.left * Time.deltaTime * 5);
	}
}
