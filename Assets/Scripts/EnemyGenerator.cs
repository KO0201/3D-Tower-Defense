using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour //敵生成処理
{
    public GameObject enemyPrefab; //敵Prefabの取得
    private float interval; //敵が生成するまで時間間隔
    private float time = 0f; //経過時間
    Vector3 thisVector3; 
    void Start()
    {
        interval = 5f; // 時間間隔
        thisVector3 = this.transform.position; //ジェネレーターのある地点
    }
 
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間計測
        if (time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab); //敵を生成する
            enemy.transform.position = thisVector3; //敵の配置をジェネレーターのある地点に設定する
            time = 0f; //再度計測
        }
    }
}
