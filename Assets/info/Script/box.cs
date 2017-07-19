using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
	int hantei = 0;
	float box_size = 0;
	float change_box_size = 0.1f;	//にゅっと動いてもらうため
	int timer = 0;
	public int display_time = 0;	//表示時間
	public float stretch_speed = 0;	//にゅっと動く速度
	
	// Use this for initialization
	void Start () {
		transform.localScale =  new Vector3( 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if ( hantei == 0 && Input.GetKeyDown(KeyCode.B)) {	//とりあえずBボタン
			hantei = 1;
		}

		//表示
		if ( hantei == 1 ) {
			if ( box_size < 1 ) {
				box_size += ( change_box_size * stretch_speed);	//拡大
			}
			transform.localScale =  new Vector3( box_size, box_size, box_size);
			timer++;
		}
		
		if ( timer == display_time ) {
			hantei = 2;
		}
		
		//縮小
		if ( hantei == 2 ) {
			if ( box_size > 0 ) {
				box_size -= ( change_box_size * stretch_speed);	//縮小
			}
			transform.localScale =  new Vector3( box_size, box_size, box_size);
			if ( box_size <= 0.01 ) {	//値の初期化
				hantei = 0;
				timer = 0;
				box_size = 0;
			}
		}
	}
}
