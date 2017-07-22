using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message_call : MonoBehaviour {
    //呼び出すメッセージウィンドウ
    public GameObject message_window;

    //ウィンドウの位置
    public Transform message_pos;

    // Use this for initialization
    void Start( ) {

    }

    // Update is called once per frame
    void Update( ) {
        // 何かのキーが押された時
        if ( Input.anyKeyDown ) {
            //複製
            GameObject message_window_copy = GameObject.Instantiate( message_window ) as GameObject;

            //ウィンドウの位置を調整
            message_window.transform.position = message_pos.position;
        }
    }
}
