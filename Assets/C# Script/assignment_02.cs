﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int mp = 53;

    public void Magic(int consume) {
        if (this.mp >= 5) {
            this.mp -= consume;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    } 
}

public class assignment_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss boss01 = new Boss();
        for (int i = 1; i <= 11; i++) {
            boss01.Magic(5);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
