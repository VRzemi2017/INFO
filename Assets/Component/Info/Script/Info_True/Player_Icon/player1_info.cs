﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_info : MonoBehaviour {

    GameObject targetCamera;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        /*
        targetCamera = GameObject.Find("Camera (eye)");  //プレイヤーのカメラの取得
        this.transform.LookAt(this.targetCamera.transform.position);
        this.transform.Rotate(new Vector3(0f, 180f, 0f));
        */

        targetCamera = GameObject.Find("remote");  //プレイヤーのカメラの取得
        this.transform.LookAt(this.targetCamera.transform.position);
        this.transform.Rotate(new Vector3(0f, 180f, 0f));

        
    }
}