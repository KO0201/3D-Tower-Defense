using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinionGenerator : MonoBehaviour ////�����~�j�I����������
{
    public GameObject minionPrefab;//�GPrefab�̎擾
    Vector3 playerVector3; //�v���C���[�̌��ݒn�_

    public int stack = 10; //�c��X�^�b�N��
    public TextMeshProUGUI stackText; //�X�^�b�N����\���e�L�X�g

    void Start()
    {

    }

    void Update()
    {
        stackText.text = stack.ToString(); //���݃X�^�b�N��

    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MeleePoint")
        {
                playerVector3 = this.transform.position; //�~�j�I�������n�_�̋L�^
        }

    }
    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "MeleePoint")
        {
            if (stack > 0)
            {
                Invoke(nameof(Generation), 0.5f);
            }
        }
    }

    public void AddStack()
    {
        stack++;
    }

    public void Subtract()
    {
        stack--;
    }

    public void ResetStack() //�X�^�b�N�̃��Z�b�g(�f�o�b�N�p)
    {
        stack = 10;
    }

    void Generation()
    {
        GameObject minion = Instantiate(minionPrefab); //�v���C���[�̋���n�_�Ƀ~�j�I���𐶐�����
        minion.transform.position = playerVector3;
        Subtract();
    }


}
