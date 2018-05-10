using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidecursor : MonoBehaviour {

	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

}
