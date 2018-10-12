using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFire : MonoBehaviour {

    public GameObject fire;
    public GameObject fireCol;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "fire")
        {
            Instantiate(fireCol, new Vector3(transform.position.x,
                transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
