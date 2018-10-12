using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject ExploadObj;
    public GameObject ExploadPos;
    // Update is called once per frame
    void Update()
    {
        //left ctrlを押したら
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("イオ");
            Instantiate(ExploadObj, ExploadPos.transform.position, Quaternion.identity);
            //Destroy(gameObject);
        }
    }
}
