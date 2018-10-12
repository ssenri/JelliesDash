using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //走るスピード
    public float speed;

    //エフェクト
    public GameObject effect1;
    //オーラ
    public GameObject Aura;


    public float time = 3.0f;

    //Fireプレハブ
    public GameObject fire;

    public GameObject FireObj;
    public GameObject FirePos;

    //Thunderプレハブ
    public GameObject thunder;

    public GameObject ThunderObj;
    public GameObject ThunderPos;

    //Explosionプレハブ
    public GameObject Explosion;

    public GameObject ExploadObj;
    public GameObject ExploadPos;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        //Zを押したら
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("メラ");
            Instantiate(FireObj, FirePos.transform.position, Quaternion.identity);
        }
        //Xを押したら
        if(Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("サンダガ");
            Instantiate(ThunderObj, ThunderPos.transform.position, Quaternion.identity);
        }
        //left ctrlを押したら
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("イオ");

            Invoke("Explosion11", 3);
            //爆発の生成
            //Instantiate(AuraObj, AuraPos.transform.position, Quaternion.identity);

            //エフェクトの生成
            effect1.SetActive(true);
            Destroy(effect1, time);

            Aura.SetActive(true);
            Destroy(Aura, time);

            //スローモーション
            Time.timeScale = 0.8f;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "thunder")
        {
            Debug.Log("麻痺");
            //speed = 0;
        }
    }

    void Explosion11()
    {
        //爆発の生成
        Instantiate(ExploadObj, ExploadPos.transform.position, Quaternion.identity);

        //スローモーション解除
        Time.timeScale = 1.0f;
    }
}

