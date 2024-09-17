using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update　1回だけ実行
    void Start()
    {
        
    }

    // Update is called once per frame　無限に実行
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //キーボードの←が押されたら
        {
            if (this.transform.position.x > -4) //X軸の位置が-4より大きかったら(壁内だったら）
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;　//変数speedにいれたくらいの速さで動かす（物を動かすときはTime.deltaTimeをかける）
            }
        }
        if ( Input.GetKey ( KeyCode.RightArrow )) //キーボードの→が押されたら
        {
            if (this.transform.position.x < 4)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
