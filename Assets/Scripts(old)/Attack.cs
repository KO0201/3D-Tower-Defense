using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //PlayerのAnimatorコンポーネント保存用
    private Animator animator;

    private const string key_isJab = "isjab";
    private const string key_isHitkick = "isHikick";
    private const string key_isSpinkick = "isSpinkick";

    // Use this for initialization
    void Start()
    {
        //PlayerのAnimatorコンポーネントを取得する
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Aを押すとjab
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool(key_isJab, true);
        }

        //Sを押すとHikick
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool(key_isHitkick, true);
        }

        //Dを押すとSpinkick
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool(key_isSpinkick, true);
        }

    }
}
