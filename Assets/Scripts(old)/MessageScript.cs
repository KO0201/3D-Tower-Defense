using UnityEngine;
using System.Collections;
 
public class MessageScript : MonoBehaviour
{
    [SerializeField]
    private Message messageScript;// Messageスクリプトを読み込む
    public string[] message1;// 管理したい会話の数だけ作成する
    public string[] message2;
    public string[] message3;

    void Start()
    {
        //StartCoroutine("Message");// Messageコルーチンを実行する
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))// Aキーがおされたら、
        {
            StartCoroutine("Message", message1);// Messageコルーチンを実行する
        }

        if (Input.GetKeyDown(KeyCode.B))// Bキーがおされたら、
        {
            StartCoroutine("Message", message2);// Messageコルーチンを実行する
        }

        if (Input.GetKeyDown(KeyCode.C))// Cキーがおされたら、
        {
            StartCoroutine("Message", message3);// Messageコルーチンを実行する
        }
    }

    IEnumerator Message(string[] Conversation)// Messageコルーチン 
    {
        yield return new WaitForSeconds(0.01f);// 0.01秒待つ
        messageScript.SetMessagePanel(Conversation);// messageScriptのSetMessagePanelを実行する
    }
    //IEnumerator Message()// Messageコルーチン 
    //{
    //   yield return new WaitForSeconds(0.01f);// 0.01秒待つ
    //    messageScript.SetMessagePanel(message1);// messageScriptのSetMessagePanelを実行する
    //}
}