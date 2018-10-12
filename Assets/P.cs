using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class P : MonoBehaviour
{
    float speed = 3.0f;
    float st = 100.0f;
    Slider _slider;
    int n = 2;

    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }


    void Update()
    {
        Move();

        if(Input.GetKey(KeyCode.B))
        {
            transform.position += transform.right * speed * n * Time.deltaTime;
            st -= 0.5f;
        }
        _slider.value = st;

        if (st <= 0)
        {
            n = 0;
        }
    }

    void Move()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
