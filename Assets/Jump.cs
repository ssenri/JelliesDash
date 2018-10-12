using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public GameObject Player;
    private Rigidbody PlayerRigid;
    public float Upspeed;


	void Start ()
    {
        PlayerRigid = Player.GetComponent<Rigidbody>();
	}

	void Update ()
    {

	}

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground" && Input.GetKeyDown(KeyCode.Space)) 
        {
            PlayerRigid.AddForce(transform.up * Upspeed);
        }
    }
}
