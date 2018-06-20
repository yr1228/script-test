using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{

    private int mp = 53;

    public void Magic(int a){

        if (mp >= 5){

            Debug.Log("魔法攻撃をした。残りMPは"+a+"。");

        }else{

            Debug.Log("MPが足りないため魔法が使えない。");
        }

        this.mp -= a;
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Boss lastboss = new Boss();
        
        for (int i = 0; i < 10; i++){

            lastboss.Magic(5);

        }

        lastboss.Magic(5);

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
