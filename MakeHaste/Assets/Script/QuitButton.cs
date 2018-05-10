using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseDown()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
