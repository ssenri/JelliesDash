using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMagic : MonoBehaviour {

    public GameObject[] Skill;

    public int number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Cキーでランダム
		if(Input.GetKeyDown(KeyCode.C))
        {
            number = Random.Range(0, Skill.Length);
            Instantiate(Skill[number], transform.position, transform.rotation);
        }
	}
}
