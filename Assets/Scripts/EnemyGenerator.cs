using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour //�G��������
{
    public GameObject enemyPrefab; //�GPrefab�̎擾
    private float interval; //�G����������܂Ŏ��ԊԊu
    private float time = 0f; //�o�ߎ���
    Vector3 thisVector3; 
    void Start()
    {
        interval = 5f; // ���ԊԊu
        thisVector3 = this.transform.position; //�W�F�l���[�^�[�̂���n�_
    }
 
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//���Ԍv��
        if (time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab); //�G�𐶐�����
            enemy.transform.position = thisVector3; //�G�̔z�u���W�F�l���[�^�[�̂���n�_�ɐݒ肷��
            time = 0f; //�ēx�v��
        }
    }
}
