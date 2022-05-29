using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionController : MonoBehaviour //味方ミニオンの挙動と判定時処理
{
    public GameObject stack; //残り配置できるミニオン数

    void Start()
    {
        stack = GameObject.Find("PlayerArmature"); //ミニオン数のデータはプレイヤー依存

    }

    // Update is called once per frame
    void Update()
    {
        /* ミニオンの生成場所がおかしくなった際にリセットする処理(デバッグ用)
        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            Destroy(this.gameObject);
            stack.GetComponent<MinionGenerator>().ResetStack();
        }
        */
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy") //敵に当たるとミニオンは消えてスタックが1還元される
        {
            stack.GetComponent<MinionGenerator>().AddStack();
            Destroy(this.gameObject);
        }
        if (col.gameObject.name == "MeleePoint")
        {
            transform.Rotate(new Vector3(0, -90, 0)); //それぞれ敵の方向を向くように調整している
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
