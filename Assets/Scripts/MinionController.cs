using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionController : MonoBehaviour //�����~�j�I���̋����Ɣ��莞����
{
    public GameObject stack; //�c��z�u�ł���~�j�I����

    void Start()
    {
        stack = GameObject.Find("PlayerArmature"); //�~�j�I�����̃f�[�^�̓v���C���[�ˑ�

    }

    // Update is called once per frame
    void Update()
    {
        /* �~�j�I���̐����ꏊ�����������Ȃ����ۂɃ��Z�b�g���鏈��(�f�o�b�O�p)
        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            Destroy(this.gameObject);
            stack.GetComponent<MinionGenerator>().ResetStack();
        }
        */
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy") //�G�ɓ�����ƃ~�j�I���͏����ăX�^�b�N��1�Ҍ������
        {
            stack.GetComponent<MinionGenerator>().AddStack();
            Destroy(this.gameObject);
        }
        if (col.gameObject.name == "MeleePoint")
        {
            transform.Rotate(new Vector3(0, -90, 0)); //���ꂼ��G�̕����������悤�ɒ������Ă���
        }
        if (col.gameObject.name == "MeleePoint (1)")
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (col.gameObject.name == "MeleePoint (2)")
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
 
}
