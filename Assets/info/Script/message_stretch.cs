﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;   //enum用

public class message_stretch : MonoBehaviour {
    int journey = 1;     //伸縮させるため
    float box_size = 0; //サイズ
    float change_box_size = 0.1f;   //にゅっと動いてもらうため
    int timer = 0;      //ウィンドウが伸びてから時間計測
    public int display_time = 0;	//表示時間
    public int text_display_time = 0;   //テキストの表示開始時間
    public float stretch_speed = 0;	//にゅっと動く速度
    public GameObject text; //表示するテキスト

    public TextMesh stringTextMesh;     //表示するテキスト

    // Use this for initialization
    void Start( ) {
        transform.localScale = new Vector3( 0, 0, 0 );
        text.SetActive( false );
    }

    // Update is called once per frame
    void Update( ) {
        //表示
        if ( journey == 1 ) {
            UpdateText( );
            if ( box_size < 1 ) {
                box_size += ( change_box_size * stretch_speed );    //拡大
            }
            transform.localScale = new Vector3( box_size, box_size, box_size );
            timer++;
        }

        if ( text_display_time <= timer & timer <= ( display_time - text_display_time ) ) {
            text.SetActive( true );
        } else {
            text.SetActive( false );
        }

        if ( timer == display_time ) {
            journey = 2;
        }

        //縮小
        if ( journey == 2 ) {
            if ( box_size > 0 ) {
                box_size -= ( change_box_size * stretch_speed );    //縮小
            }
            transform.localScale = new Vector3( box_size, box_size, box_size );
            if ( box_size <= 0.01 ) {   //値の初期化
                journey = 0;
                timer = 0;
                box_size = 0;
                transform.localScale = new Vector3( 0, 0, 0 );
            }
        }
    }

    void UpdateText( ) {    //テキストの中身
        stringTextMesh.text = "何かのキーが押されました。";
    }

    void OnCollisionEnter( Collision otherObj ) {
        if ( otherObj.gameObject.tag == "Missile" ) {
            Destroy( gameObject, .3f );
        }
    }
}
