using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour //敵の挙動と判定時処理
{
    NavMeshAgent agent; //敵の移動範囲

    private Vector3 stoneTransform;

    public int stoneHP; //現在のStoneの残りHPを参照するための変数
    public GameObject stoneHPObject;

    public GameObject score; //スコアを追加するための変数

    void Start()
    {
        stoneTransform = GameObject.Find("Stone").transform.position; //敵がStoneへ向かうための座標取得
        score = GameObject.Find("ScoreText"); //スコアを追加するための参照
        agent = GetComponent<NavMeshAgent>(); //敵の移動範囲の取得
    }
    public void Update()
    {
        agent.destination = stoneTransform; //敵がStoneの座標に向かって移動できるようにする
        stoneHP = stoneHPObject.GetComponent<Stone>().hp; //Stoneの残りHPの取得
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            score.GetComponent<Score>().AddScore(); //得点が1増える
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Minion")
        {
            score.GetComponent<Score>().AddScore();
            Destroy(this.gameObject);
        }

    }
}
