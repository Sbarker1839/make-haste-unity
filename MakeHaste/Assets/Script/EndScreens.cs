using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreens : MonoBehaviour {

    //[SerializeField] private Text timer;
    public Text timerText;
    // Use this for initialization
    void Start () {
        timerText.text = "Your Final Time: " + TrackTarget.endTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
