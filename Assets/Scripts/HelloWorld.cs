﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public new string name = "Untitled";
	// Use this for initialization
	void Start () {
        print(name);
        for(var i = 0; i < 10; i++)
        {
            print(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
