using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour //Stone�̗̑͏���
{
    public int hp = 100;

    //private EnemyStatus virusData;

    private void Start()
    {
        //virusData = Resources.Load<EnemyStatus>("VirusStatus"); //�e�G�̃X�e�[�^�X���Q�Ƃł���悤�ɂ���(TBD)
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
        hp = hp - 10; //�G�̍U��
    }
}
