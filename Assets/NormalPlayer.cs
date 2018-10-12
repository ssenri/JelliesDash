using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlayer : MonoBehaviour {

    //パラメータ
    public float Speed;

    public float Jump;

    public float Stamina;

    public float Mind;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * Speed * Time.deltaTime;

	}
}
