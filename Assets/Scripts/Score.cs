using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour //現在スコア&ハイスコアの処理、画面描画
{

    public int score; //現在スコア
    public int highScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public AudioClip SE;
    AudioSource audioSource;
    bool scoreUpdate = false; //スコアが更新されたときに1回だけ行われる処理

    void Start()
    {
        PlayerPrefs.DeleteAll(); //セーブデータに残るハイスコアデータの削除
        score = 0;

        highScore = PlayerPrefs.GetInt("SCORE", 0); //過去のハイスコアをロードする
        highScoreText.text = "\nHIGH SCORE:" + highScore.ToString(); //過去のハイスコア表示する

        audioSource = GetComponent<AudioSource>(); //ハイスコアが更新されたときに流れるSEを設定する
    }

    public void AddScore()
    {
        score++;
    }
    void Update()
    {
        scoreText.text = "SCORE:" + score.ToString(); //現在のスコア表示する

        if (score > highScore) //スコア更新処理
        {
            highScore = score; 
            
            highScoreText.text = "ハイスコア更新!\nHIGH SCORE:" + highScore.ToString(); //現在のハイスコアを表示する

            if (scoreUpdate == false) //スコア更新時に流れるSEは1回のみの処理
            {
                audioSource.PlayOneShot(SE);
                scoreUpdate = true;
            }

            PlayerPrefs.SetInt("SCORE", highScore); //ハイスコアのセーブ処理
            PlayerPrefs.Save();
        }
        
    }
    
}
