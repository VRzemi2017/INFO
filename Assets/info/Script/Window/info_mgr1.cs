using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_mgr1 : MonoBehaviour {
	[SerializeField] GameObject window_single = null;
	//const int OFF_TIME = 5;
	//float _time;
	// Use this for initialization
	void Start () {
		Instantiate (window_single);
		window_single = null;
		window_single = GameObject.Find ("Message_quad 2(Clone)");
		//_time = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//window.SetActive (false);
		Debug.Log( ( window_single != null ) );
		if (Input.GetKey(KeyCode.W)) {
			call_info ();
		}
		/*_time += Time.deltaTime;
		if (_time > OFF_TIME) {
			window.SetActive (false);
		}*/
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


}
