using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    //火の速度
    public int speed = 10;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.right.normalized * speed;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Box")
        {
            Destroy(this.gameObject);
        }
    }
}
