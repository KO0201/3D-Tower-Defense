using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //Player��Animator�R���|�[�l���g�ۑ��p
    private Animator animator;

    private const string key_isJab = "isjab";
    private const string key_isHitkick = "isHikick";
    private const string key_isSpinkick = "isSpinkick";

    // Use this for initialization
    void Start()
    {
        //Player��Animator�R���|�[�l���g���擾����
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //A��������jab
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool(key_isJab, true);
        }

        //S��������Hikick
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool(key_isHitkick, true);
        }

        //D��������Spinkick
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool(key_isSpinkick, true);
        }

    }
}
