using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.UI;


public class GameManager2 : MonoBehaviour
{
    public bool night, talkingNow;
    public GameObject messageWindow;
    private Image messageWindowI;
    public List<string> charaTalkingWords = new List<string>();
    public TextMeshProUGUI talkingText, nameText;
    public AudioClip proceedingTalkSE;

    

    void Start()
    {
        messageWindowI = messageWindow.GetComponent<Image>();
        


    }

    void Update()
    {

    }

    public void DisplayMessageWindow(List<string> words, string name)
    {
        nameText.text = name;
        charaTalkingWords.Clear();
        charaTalkingWords = new List<string>(words);
        messageWindow.SetActive(true);
        talkingText.text = charaTalkingWords[0];
        charaTalkingWords.RemoveAt(0);
    }

    public void ProceedingTalk(AudioSource charaAS, float pitch)
    {
        if (charaTalkingWords.Count > 0)
        {
            if (talkingNow == true) return;
            // talkingText.text = charaTalkingWords[0];
            StartCoroutine(TalkText(charaAS, pitch));

            //audioSourceSE.PlayOneShot(proceedingTalkSE);
        }
        else
        {
            messageWindow.SetActive(false);
            //audioSourceSE.PlayOneShot(proceedingTalkSE);
        }
    }
    public void CloseMessageWindow()
    {
        messageWindow.SetActive(false);
    }

    private IEnumerator TalkText(AudioSource charaAS, float pitch)
    {
        talkingNow = true;
        int messageCount = 0; //���ݕ\�����̕�����
        talkingText.text = ""; //�e�L�X�g�̃��Z�b�g
        float minPitch = pitch - 0.5f;
        float maxPitch = pitch + 0.5f;
        while (charaTalkingWords[0].Length > messageCount)//���������ׂĕ\�����Ă��Ȃ��ꍇ���[�v
        {
            if (messageCount % 2 == 0)
            {
                charaAS.pitch = Random.Range(minPitch, maxPitch);
                charaAS.PlayOneShot(proceedingTalkSE);
            }
            talkingText.text += charaTalkingWords[0][messageCount];//�ꕶ���ǉ�
            messageCount++;//���݂̕�����
            yield return new WaitForSeconds(0.04f);
        }
        charaTalkingWords.RemoveAt(0);
        talkingNow = false;
    }

}
