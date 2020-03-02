using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment_01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = { 5, 60, 90, 22, 100 };

        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }

        for (int r = 4; r >= 0; r--) {
            Debug.Log(array[r]);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
