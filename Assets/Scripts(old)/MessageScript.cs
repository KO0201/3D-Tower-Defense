using UnityEngine;
using System.Collections;
 
public class MessageScript : MonoBehaviour
{
    [SerializeField]
    private Message messageScript;// Message�X�N���v�g��ǂݍ���
    public string[] message1;// �Ǘ���������b�̐������쐬����
    public string[] message2;
    public string[] message3;

    void Start()
    {
        //StartCoroutine("Message");// Message�R���[�`�������s����
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))// A�L�[�������ꂽ��A
        {
            StartCoroutine("Message", message1);// Message�R���[�`�������s����
        }

        if (Input.GetKeyDown(KeyCode.B))// B�L�[�������ꂽ��A
        {
            StartCoroutine("Message", message2);// Message�R���[�`�������s����
        }

        if (Input.GetKeyDown(KeyCode.C))// C�L�[�������ꂽ��A
        {
            StartCoroutine("Message", message3);// Message�R���[�`�������s����
        }
    }

    IEnumerator Message(string[] Conversation)// Message�R���[�`�� 
    {
        yield return new WaitForSeconds(0.01f);// 0.01�b�҂�
        messageScript.SetMessagePanel(Conversation);// messageScript��SetMessagePanel�����s����
    }
    //IEnumerator Message()// Message�R���[�`�� 
    //{
    //   yield return new WaitForSeconds(0.01f);// 0.01�b�҂�
    //    messageScript.SetMessagePanel(message1);// messageScript��SetMessagePanel�����s����
    //}
}