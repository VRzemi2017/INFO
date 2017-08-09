using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_Mgr : MonoBehaviour {
    public GameObject message_window;   //呼び出すメッセージウィンドウ

    // Use this for initialization
    void Start( ) {
    }

    // Update is called once per frame
    void Update( ) {
    }
    
	public void Generat( Vector3 camera_pos, Quaternion camera_rot, float info_pos_y, Vector3 front ) {		//向きと位置の調節要必要
		// position
		Vector3 pos = camera_pos + front + new Vector3( 0, info_pos_y, 0 );
		// 回転
		Vector3 rot = camera_rot.eulerAngles;
		rot = new Vector3 (0, rot.y, 0);
		Quaternion qua = Quaternion.Euler (rot);
		// 生成
		Instantiate( message_window, pos, qua );
    }
}
