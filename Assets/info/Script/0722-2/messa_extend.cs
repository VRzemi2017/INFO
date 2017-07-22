using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messa_extend : MonoBehaviour {
    float size = 0;     //ウィンドウのサイズ
    float extend_num = 0.1f;   //おまじない
    public float extend_speed = 0; //伸びる速さ
    int text_timer = 0;             //ウィンドウが伸び始めてから計測
    public int text_display_time = 0;   //テキストの表示開始時間

    public GameObject window;           //ウィンドウ
    public GameObject text;             //表示するテキスト
    public TextMesh stringTextMesh;     //表示するテキスト

    messa_shrink messaShrink;

    // Use this for initialization
    void Start () {
        window.transform.localScale = new Vector3( 0, 0, 0 );
        UpdateText( );
        text.SetActive( false );

        messaShrink = GetComponent<messa_shrink>( );
    }

    // Update is called once per frame
    void Update( ) {
        if ( size < 1.0 ) {
            size += ( extend_num * extend_speed );    //拡大
        }
        window.transform.localScale = new Vector3( size, size, size );     //反映

        if ( size >= 1.0 ) {
            if ( text_timer < text_display_time ) {
                text_timer++;
            }
            if ( text_timer >= text_display_time ) {
                text.SetActive( true );
            }

            if ( Input.anyKeyDown ) {
                messaShrink.Update( );
            }
        }
    }

    void UpdateText( ) {    //テキストの中身
        stringTextMesh.text = "ここに　テキストを　表示します";
    }
}
