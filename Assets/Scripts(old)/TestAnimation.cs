using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestAnimation : MonoBehaviour {

	// Animator コンポーネント
	private Animator animator;

	// 設定したフラグの名前
	private const string key_isRun = "isRun";
	private const string key_isJump = "isJump";
	private const string key_isJab = "isJab";
	private const string key_isHitkick = "isHikick";
	private const string key_isSpinkick = "isSpinkick";

	// 初期化メソッド
	void Start()
	{
		// 自分に設定されているAnimatorコンポーネントを習得する
		animator = GetComponent<Animator>();
	}

	// 1フレームに1回コールされる
	void Update()
	{

		// 矢印下ボタンを押下している
		if (Input.GetKey(KeyCode.W))
		{
			// WaitからRunに遷移する
			animator.SetBool(key_isRun, true);
		}
		else
		{
			// RunからWaitに遷移する
			animator.SetBool(key_isRun, false);
		}

		// Wait or Run からJumpに切り替える処理
		// スペースキーを押下している
		if (Input.GetKey(KeyCode.Space))
		{
			// Wait or RunからJumpに遷移する
			animator.SetBool(key_isJump, true);
		}
		else
		{
			// JumpからWait or Runに遷移する
			animator.SetBool(key_isJump, false);
		}
		//Aを押すとjab
		if (Input.GetKey(KeyCode.Q))
		{
			animator.SetBool(key_isJab, true);
		}
		else
        {
			animator.SetBool(key_isJab, false);
		}

		//Sを押すとHikick
		if (Input.GetKey(KeyCode.E))
		{
			animator.SetBool(key_isHitkick, true);
		}
		else
		{
			animator.SetBool(key_isHitkick, false);
		}

		//Dを押すとSpinkick
		if (Input.GetKey(KeyCode.R))
		{
			animator.SetBool(key_isSpinkick, true);
		}
		else
		{
			animator.SetBool(key_isSpinkick, false);
		}
	}
}