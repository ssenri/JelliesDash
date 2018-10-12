using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour {

    public GameObject effect1;

    public float time=3.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("オン");
            effect1.SetActive(true);

            Destroy(effect1, time);
        }
	}
}
