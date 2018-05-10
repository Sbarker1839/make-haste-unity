using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {

    public Text DistanceText;

    public GameObject a;
    public GameObject b;
    public static int dist;


    void Update()
    {

            dist = (int) Vector3.Distance(a.transform.position, b.transform.position);

            DistanceText.text = dist.ToString()+" M";
        
    }
}
