using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //�L�����N�^�[�̑����Ԃ��Ǘ�����t���O
    [SerializeField] public bool onGround = true;
    [SerializeField] public bool inJumping = false;

    //rigidbody�I�u�W�F�N�g�i�[�p�ϐ�
    Rigidbody rb;

    //�ړ����x�̒�`
    float speed = 6f;

    //�_�b�V�����x�̒�`
    float sprintspeed = 9f;

    //�����]�����x�̒�`
    float angleSpeed = 200;

    //�ړ��̌W���i�[�p�ϐ�
    float v;
    float h;

    void Update() 
    {

        //Shift+�㉺�L�[�Ń_�b�V���A�㉺�L�[�Œʏ�ړ�,����ȊO�͒�~
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            v = Time.deltaTime * sprintspeed;
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
            v = -Time.deltaTime * sprintspeed;
        else if (Input.GetKey(KeyCode.W))
            v = Time.deltaTime * speed;
        else if (Input.GetKey(KeyCode.S))
            v = -Time.deltaTime * speed;
        else
            v = 0;

        //�ړ��̎��s
        if (!inJumping)//�󒆂ł̈ړ����֎~
        {
            transform.position += transform.forward * v;
        }

        //�X�y�[�X�{�^���ŃW�����v����
        if (onGround)
        {
            if (Input.GetKey(KeyCode.B))
            {
                
                //�W�����v�����邽�ߏ�����ɗ͂𔭐�
                rb.AddForce(transform.up * 8, ForceMode.Impulse);
                //�W�����v���͒n�ʂƂ̐ڐG�����false�ɂ���
                onGround = false;
                inJumping = true;

                //�O��L�[�������Ȃ���W�����v�����Ƃ��͑O������̗͂�����
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rb.AddForce(transform.forward * 6f, ForceMode.Impulse);
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb.AddForce(transform.forward * -3f, ForceMode.Impulse);
                }
            }
        }


        //���E�L�[�ŕ����]��
        if (Input.GetKey(KeyCode.D))
            h = Time.deltaTime * angleSpeed;
        else if (Input.GetKey(KeyCode.A))
            h = -Time.deltaTime * angleSpeed;
        else
            h = 0;

        //�����]������̎��s
        transform.Rotate(Vector3.up * h);

    }
    //�n�ʂɐڐG�����Ƃ��ɂ�onGround��true�Ainjumping��false�ɂ���
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            onGround = true;
            inJumping = false;
        }
    }
}