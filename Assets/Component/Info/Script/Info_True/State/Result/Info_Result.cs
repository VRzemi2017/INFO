﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info_Result : MonoBehaviour {

    private int _pick_up;
    private int _damage;
    private int _teleport;
    private int _event;

    public int PickUp { set { _pick_up = value; } }
    public int Damage { set { _damage = value; } }
    public int Teleport { set { _teleport = value; } }
    public int Event { set { _event = value; } }

    // Use this for initialization
    void Start () {
        float info_pos_y = 0.06f;     //ウィンドウの高さ
        GameObject camera = GameObject.Find("Camera (eye)");  //プレイヤーのカメラの取得
        Vector3 camera_pos = camera.transform.position;         //プレイヤーのカメラ座標
        Vector3 front = camera.transform.forward * 20f;        //カメラの正面*距離
        Quaternion camera_rot = camera.transform.rotation;      //プレイヤーのカメラの角度

        // position
        Vector3 pos = camera_pos + front + new Vector3(0, info_pos_y, 0); //どの位置に出すか
                                                                          // 回転
        Vector3 rot = camera_rot.eulerAngles;                               //どの角度で出すか
        rot = new Vector3(0, rot.y, 0);
        Quaternion qua = Quaternion.Euler(rot);

        this.transform.position = pos;        //ウィンドウのポジション
        this.transform.rotation = qua;        //ウィンドウの角度

        _pick_up = InfoManager.pickup;
        _damage = InfoManager.rob;
        _teleport = InfoManager.teleport;
    }
	
	// Update is called once per frame
	void Update () {
        // 宝石の取得数を設定
        Transform num_mesh = transform.GetChild(0).transform.GetChild(1).transform.GetChild(2).transform;
        num_mesh.GetChild(0).GetComponent<TextMesh>().text = _pick_up.ToString();
        num_mesh.GetChild(1).GetComponent<TextMesh>().text = _damage.ToString();
        num_mesh.GetChild(2).GetComponent<TextMesh>().text = _teleport.ToString();
        num_mesh.GetChild(3).GetComponent<TextMesh>().text = _event.ToString();

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log(_pick_up);
        }


        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SceneManager.LoadScene(1);
        }
    }
}
