using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update�@1�񂾂����s
    void Start()
    {
        
    }

    // Update is called once per frame�@�����Ɏ��s
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //�L�[�{�[�h�́��������ꂽ��
        {
            if (this.transform.position.x > -4) //X���̈ʒu��-4���傫��������(�Ǔ���������j
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;�@//�ϐ�speed�ɂ��ꂽ���炢�̑����œ������i���𓮂����Ƃ���Time.deltaTime��������j
            }
        }
        if ( Input.GetKey ( KeyCode.RightArrow )) //�L�[�{�[�h�́��������ꂽ��
        {
            if (this.transform.position.x < 4)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
