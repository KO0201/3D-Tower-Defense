using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour //�G�̋����Ɣ��莞����
{
    NavMeshAgent agent; //�G�̈ړ��͈�

    private Vector3 stoneTransform;

    public int stoneHP; //���݂�Stone�̎c��HP���Q�Ƃ��邽�߂̕ϐ�
    public GameObject stoneHPObject;

    public GameObject score; //�X�R�A��ǉ����邽�߂̕ϐ�

    void Start()
    {
        stoneTransform = GameObject.Find("Stone").transform.position; //�G��Stone�֌��������߂̍��W�擾
        score = GameObject.Find("ScoreText"); //�X�R�A��ǉ����邽�߂̎Q��
        agent = GetComponent<NavMeshAgent>(); //�G�̈ړ��͈͂̎擾
    }
    public void Update()
    {
        agent.destination = stoneTransform; //�G��Stone�̍��W�Ɍ������Ĉړ��ł���悤�ɂ���
        stoneHP = stoneHPObject.GetComponent<Stone>().hp; //Stone�̎c��HP�̎擾
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            score.GetComponent<Score>().AddScore(); //���_��1������
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Minion")
        {
            score.GetComponent<Score>().AddScore();
            Destroy(this.gameObject);
        }

    }
}
