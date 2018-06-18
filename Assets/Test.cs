using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = { 12, 28, 34, 23, 45 };

        for (int i = 0; i < 5; i++) {

            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; 0 <= i; i--){

            Debug.Log(array[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
