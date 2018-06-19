using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{

    int mp = 53;

    public void Magic(int a){

        Debug.Log("魔法攻撃をした。残りMPは" + a + "。");
        this.mp -= a;

        if (mp < 5){

            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Boss lastboss = new Boss();

        lastboss.Magic(5);
        for(int i = 0; i < 10; i++){

            lastboss.Magic(5);
        }


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
