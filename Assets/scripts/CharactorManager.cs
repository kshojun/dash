using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorManager : MonoBehaviour {

	private bool _isLeftMove;
	private bool _isStop;
	private bool _isJump;
	private Animator _animator;


	private bool _isJumping;//衝突判定

	public bool isJumping{
		get {return _isJumping;}
	}
	// Use this for initialization
	void Start () {
		//初期化
		this._animator = this.GetComponent<Animator>();
		this._isLeftMove = true;
		this._isJumping = false;
		this._isStop = true;
	}

	// Update is called once per frame
	void Update () {
		var v = this.GetComponent<Rigidbody2D>().velocity;
		//Debug.Log(this._isJumping + "/" + v.x );

		//少しでも動いていたら
		if(v.x > 0.1)
		{
			this._isLeftMove = true;
			this._isStop = false;
		}else{
			this._isStop = true;
			this._isLeftMove = false;
		}

		this._animator.SetBool("isJump",this._isJumping);
		this._animator.SetBool("isStop",this._isStop);
		this._animator.SetBool("isLeftMove",this._isLeftMove);
	}
	//設置してたらジャンプをfalse
	public void OnCollisionEnter2D(Collision2D col){
		this._isJumping = false;
	}
	//設置からはずれたらジャンプをtrue
	public void OnCollisionExit2D(Collision2D col){
		this._isJumping = true;
	}
}
