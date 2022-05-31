using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour //�Q�[���̐i�s������S������(��ɃQ�[���I�[�o�[�A���g���C�̔���)
{
    [SerializeField]
    GameObject clearUI, gameOverUI;

    public GameObject canvas;

    public GameObject stone; //stone , stoneHP��Stone�̎c��̗͏����擾���邽�߂̕ϐ�
    public int stoneHP;

    Button[] buttons;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stoneHP > 0) 
        {
            stoneHP = stone.GetComponent<Stone>().hp; //Stone�̎c��̗͂��擾��������
        }
        if(stoneHP <= 0) //GameOver����
        {
            gameOverUI.SetActive(true); //GameOver�̕������Z�b�g����
            buttons = canvas.GetComponentsInChildren<Button>(); //���g���C�p�{�^��
            buttons[0].onClick.AddListener(LoadCurrentScene);
            Time.timeScale = 0; //�Q�[��������~�߂�
            if (Input.GetKey(KeyCode.Alpha0)) //�{�^�������łȂ�0�L�[�ł����g���C�ł���
            {
                LoadCurrentScene();
                Time.timeScale = 1; //�Q�[�����ĊJ����
            }
        }
    }

    public void LoadCurrentScene() //�Q�[���ēǂݍ���
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
