using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour //ゲームの進行処理を担当する(主にゲームオーバー、リトライの判定)
{
    [SerializeField]
    GameObject clearUI, gameOverUI;

    public GameObject canvas;

    public GameObject stone; //stone , stoneHPはStoneの残り体力情報を取得するための変数
    private int stoneHP;

    Button[] buttons;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (stoneHP >= 0) 
        {
            stoneHP = stone.GetComponent<Stone>().hp; //Stoneの残り体力を取得し続ける
        }
        if(stoneHP <= 90) //GameOver処理
        {
     
            gameOverUI.SetActive(true); //GameOverの文字をセットする
            buttons = canvas.GetComponentsInChildren<Button>(); //リトライ用ボタン
            buttons[0].onClick.AddListener(LoadCurrentScene);
            
            if (Input.GetKey(KeyCode.Alpha0)) //ボタンだけでなく0キーでもリトライできる
            {
                LoadCurrentScene();
            }

        }
    }

    public void LoadCurrentScene() //ゲーム再読み込み
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
