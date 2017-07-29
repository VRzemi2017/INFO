using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_Mgr : MonoBehaviour {
    public GameObject message_window;   //呼び出すメッセージウィンドウ

	public Transform camera_trans;       //ウィンドウの位置
    // Use this for initialization
    void Start( ) {
    }

    // Update is called once per frame
    void Update( ) {
        // 何かのキーが押された時
        if ( Input.GetKeyDown( KeyCode.Space ) ) {
            //複製
            GameObject message_window_copy = GameObject.Instantiate( message_window ) as GameObject;

            //ウィンドウの位置を調整
			message_window_copy.transform.position = camera_trans.position;
			message_window_copy.transform.rotation = camera_trans.rotation;
        }
    }
	public void hit ( ) {
		Debug.Log ("hittttttttttttttttttttttttt");
		// カメラに追従
		//GameObject message_window_copy = GameObject.Instantiate (message_window) as GameObject;
		//ウィンドウの位置を調整
		//message_window_copy.transform.position = message_pos.position;
		//message_window_copy.transform.rotation = message_pos.rotation;
		//　位置固定
		Vector3 angle = camera_trans.rotation.eulerAngles;
		Quaternion qua = Quaternion.Euler (new Vector3 (0, angle.y, 0));
		Instantiate( message_window, camera_trans.position + ( Vector3.back * 10f ), qua );
	}
}
