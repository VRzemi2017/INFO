using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class info_mgr1 : MonoBehaviour {
	[SerializeField] GameObject window_single = null;
    public int state_num = 0;

    public GameObject state_window;   //ゲームスタート、ゲームオーバー
    int time = 0;

    void Start () {
		Instantiate (window_single);
		window_single = null;
		window_single = GameObject.Find ("Message_quad 2(Clone)");

        State_call();
    }
	
	// Update is called once per frame
	void Update () {
		//window.SetActive (false);
		if (Input.GetKey(KeyCode.W)) {
			call_info ();
		}

        time++;
        if (time == 600)
        {
            state_num = 1;
            State_call();
        }

        
    }

    public void call_info( ) {
		//window.SetActive (true);
		float window_y = -0.7f;		//ウィンドウの高さ
		GameObject camera = GameObject.Find ("Camera (eye)");
		Vector3 pos = camera.transform.position;
		Debug.Log ("camera" + pos);
		Vector3 front = camera.transform.forward * 2.5f;
		Quaternion camera_rot = camera.transform.rotation;

		// 位置
		window_single.transform.localPosition = pos + front + new Vector3( 0, window_y, 0 );

		// 回転
		Vector3 rot = camera_rot.eulerAngles;
		rot = new Vector3 (0, rot.y, 0);
		Quaternion qua = Quaternion.Euler (rot);
		window_single.transform.localRotation = qua;

		str_mgr1 call = GameObject.Find( "Message_bg" ).GetComponent<str_mgr1>( );
		call.reset ();
	}

    void State_call()
    {     //向きと位置の調節要必要
        /*
        float info_pos_y = -0.7f;     //ウィンドウの高さ
        GameObject camera = GameObject.Find("Camera (eye)");  //プレイヤーのカメラの取得
        Vector3 camera_pos = camera.transform.position;         //プレイヤーのカメラ座標
        Vector3 front = camera.transform.forward * 2.0f;        //カメラの正面*距離
        Quaternion camera_rot = camera.transform.rotation;      //プレイヤーのカメラの角度

        // position
        Vector3 pos = camera_pos + front + new Vector3(0, info_pos_y, 0); //どの位置に出すか
                                                                          // 回転
        Vector3 rot = camera_rot.eulerAngles;                               //どの角度で出すか
        rot = new Vector3(0, rot.y, 0);
        Quaternion qua = Quaternion.Euler(rot);*/
        // 生成
        Instantiate(state_window/*, pos, qua*/);        //呼び出すウィンドウを、どの位置で、どの角度で。
    }
}
