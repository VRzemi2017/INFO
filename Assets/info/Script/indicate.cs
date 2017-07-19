using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicate : MonoBehaviour {
    public GameObject message_point;
    public GameObject camera_pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 camera = GameObject.Find( "hogehoge" ).transform.position;
        message_point.transform.position = new Vector3( Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z );
    }
}

/*
using UnityEngine;
using System.Collections;
 
public class Shooting : MonoBehaviour {
 
	// bullet prefab
	public GameObject bullet;
 
	// 弾丸発射点
	public Transform muzzle;
 
	// 弾丸の速度
	public float speed = 1000;
 
	// Use this for initialization
	void Start () {
 
	}
 
	// Update is called once per frame
	void Update () {
		// z キーが押された時
		if(Input.GetKeyDown (KeyCode.Z)){
			// 弾丸の複製
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;
 
			Vector3 force;
			force = this.gameObject.transform.forward * speed;
			// Rigidbodyに力を加えて発射
			bullets.GetComponent<Rigidbody>().AddForce (force);
			// 弾丸の位置を調整
			bullets.transform.position = muzzle.position;
		}
	}
} 
*/
