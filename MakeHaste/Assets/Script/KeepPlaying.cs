using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlaying : MonoBehaviour {

    private static KeepPlaying obj;

    void Awake()
    {
        //if we don't have an [_instance] set yet
        if (!obj)
            obj = this;
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
    }
}
