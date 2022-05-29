using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour //Stoneの体力処理
{
    public int hp = 100;

    //private EnemyStatus virusData;

    private void Start()
    {
        //virusData = Resources.Load<EnemyStatus>("VirusStatus"); //各敵のステータスを参照できるようにする(TBD)
    }

     void Update()
    {

    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Damage();

        }
    }
    public void Damage()
    {
        hp = hp - 10; //敵の攻撃
    }
}
