using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameObject _charactor;　//キャラ
	private CharactorManager _charactorScript;

	float jumpnum = 200f;

	// Use this for initialization
	void Start () {
		//キャラの取得
		this._charactor = GameObject.Find("charactor");

		//キャラスクリプトの取得
		this._charactorScript = this._charactor.GetComponent<CharactorManager>();
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(this._charactorScript.isJumping);
		// キーの入力
		//float horizontal = Input.GetAxis("Horizontal");
		//キャラに力を加える

		this._charactor.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 4.0f);
		//スペースキー

		if(Input.GetKeyDown("space") && this._charactorScript.isJumping == false){
			//animator.Play("walk_left");
			this._charactor.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpnum);
		}


		if (Input.touchCount > 0 && this._charactorScript.isJumping == false){
			this._charactor.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpnum);
		}


	}
}
