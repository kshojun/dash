using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_NonPhysics2d : MonoBehaviour {

	public float speed = 15.0f;

	float jumpVy;
	// Use this for initialization
	void Start () {
		jumpVy = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		float height = this.transform.position.y + jumpVy;
		Debug.Log(height);

		//ジャンプ
		if(height <= 0.0f){
			height = 0.0f;
			jumpVy = 0.0f;

			//ジャンプチェック
			if(Input.GetKeyDown("space")){
				jumpVy = +1.3f;
			}
		}else{
			jumpVy -= 0.2f;
		}

		this.transform.Translate(0.1f, height, 0);


		//カメラ移動
		//GameObject gocom = GameObject.Find("Main Camera");
		//gocom.transform.Translate(0.1f, 0, 0);

	}
	//プレイヤーの移動
}
