using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messa_shrink : MonoBehaviour {
    float size = 1;     //ウィンドウのサイズ
    float shrink_num = 0.1f;   //おまじない
    public float shrink_speed = 0; //縮む速さ
    int text_timer = 0;             //テキストが消えてから計測
    public int text_display_time = 0;   //テキストが消えてからウィンドウが縮むまでの猶予

    public GameObject window;           //ウィンドウ
    public GameObject text;             //表示するテキスト

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void Update( ) {
        text.SetActive( false );
        if ( text_timer < text_display_time ) {
            text_timer++;
        } else if ( text_timer >= text_display_time ) {
            if ( size > 0 ) {
                size -= ( shrink_num * shrink_speed );    //縮小
            }
        }
    }
}
