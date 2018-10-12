using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour {

    //タイマー
    public float time = 2.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //2秒後に消える
        Destroy(this.gameObject, time);
	}
}
