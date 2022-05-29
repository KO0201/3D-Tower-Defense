using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinionGenerator : MonoBehaviour ////味方ミニオン生成処理
{
    public GameObject minionPrefab;//敵Prefabの取得
    Vector3 playerVector3; //プレイヤーの現在地点

    public int stack = 10; //残りスタック数
    public TextMeshProUGUI stackText; //スタック数を表すテキスト

    void Start()
    {

    }

    void Update()
    {
        stackText.text = stack.ToString(); //現在スタック数

    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MeleePoint")
        {
                playerVector3 = this.transform.position; //ミニオン生成地点の記録
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

    public void ResetStack() //スタックのリセット(デバック用)
    {
        stack = 10;
    }

    void Generation()
    {
        GameObject minion = Instantiate(minionPrefab); //プレイヤーの居る地点にミニオンを生成する
        minion.transform.position = playerVector3;
        Subtract();
    }


}
