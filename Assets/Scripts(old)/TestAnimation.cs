using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestAnimation : MonoBehaviour {

	// Animator �R���|�[�l���g
	private Animator animator;

	// �ݒ肵���t���O�̖��O
	private const string key_isRun = "isRun";
	private const string key_isJump = "isJump";
	private const string key_isJab = "isJab";
	private const string key_isHitkick = "isHikick";
	private const string key_isSpinkick = "isSpinkick";

	// ���������\�b�h
	void Start()
	{
		// �����ɐݒ肳��Ă���Animator�R���|�[�l���g���K������
		animator = GetComponent<Animator>();
	}

	// 1�t���[����1��R�[�������
	void Update()
	{

		// ��󉺃{�^�����������Ă���
		if (Input.GetKey(KeyCode.W))
		{
			// Wait����Run�ɑJ�ڂ���
			animator.SetBool(key_isRun, true);
		}
		else
		{
			// Run����Wait�ɑJ�ڂ���
			animator.SetBool(key_isRun, false);
		}

		// Wait or Run ����Jump�ɐ؂�ւ��鏈��
		// �X�y�[�X�L�[���������Ă���
		if (Input.GetKey(KeyCode.Space))
		{
			// Wait or Run����Jump�ɑJ�ڂ���
			animator.SetBool(key_isJump, true);
		}
		else
		{
			// Jump����Wait or Run�ɑJ�ڂ���
			animator.SetBool(key_isJump, false);
		}
		//A��������jab
		if (Input.GetKey(KeyCode.Q))
		{
			animator.SetBool(key_isJab, true);
		}
		else
        {
			animator.SetBool(key_isJab, false);
		}

		//S��������Hikick
		if (Input.GetKey(KeyCode.E))
		{
			animator.SetBool(key_isHitkick, true);
		}
		else
		{
			animator.SetBool(key_isHitkick, false);
		}

		//D��������Spinkick
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