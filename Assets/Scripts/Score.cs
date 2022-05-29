using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour //���݃X�R�A&�n�C�X�R�A�̏����A��ʕ`��
{

    public int score; //���݃X�R�A
    public int highScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public AudioClip SE;
    AudioSource audioSource;
    bool scoreUpdate = false; //�X�R�A���X�V���ꂽ�Ƃ���1�񂾂��s���鏈��

    void Start()
    {
        PlayerPrefs.DeleteAll(); //�Z�[�u�f�[�^�Ɏc��n�C�X�R�A�f�[�^�̍폜
        score = 0;

        highScore = PlayerPrefs.GetInt("SCORE", 0); //�ߋ��̃n�C�X�R�A�����[�h����
        highScoreText.text = "\nHIGH SCORE:" + highScore.ToString(); //�ߋ��̃n�C�X�R�A�\������

        audioSource = GetComponent<AudioSource>(); //�n�C�X�R�A���X�V���ꂽ�Ƃ��ɗ����SE��ݒ肷��
    }

    public void AddScore()
    {
        score++;
    }
    void Update()
    {
        scoreText.text = "SCORE:" + score.ToString(); //���݂̃X�R�A�\������

        if (score > highScore) //�X�R�A�X�V����
        {
            highScore = score; 
            
            highScoreText.text = "�n�C�X�R�A�X�V!\nHIGH SCORE:" + highScore.ToString(); //���݂̃n�C�X�R�A��\������

            if (scoreUpdate == false) //�X�R�A�X�V���ɗ����SE��1��݂̂̏���
            {
                audioSource.PlayOneShot(SE);
                scoreUpdate = true;
            }

            PlayerPrefs.SetInt("SCORE", highScore); //�n�C�X�R�A�̃Z�[�u����
            PlayerPrefs.Save();
        }
        
    }
    
}
