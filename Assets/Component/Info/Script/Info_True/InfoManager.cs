﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour {

    //infomation呼び出し用
    public enum InfoCase
    {
        INFO_WAIT,  //待機

        INFO_TEST,
        INFO_DAMAGE,
        INFO_GET,

        INFO_CASE_MAX,
    }
    public static InfoCase Info_Case = InfoCase.INFO_WAIT;      //待機
    public GameObject called_window;           //他スクリプトから呼び出されるウィンドウ

    //ゲームスタート、タイムアップ、リザルト呼び出し用
    public GameObject state_window;   //ゲームスタート、タイムアップ用のウィンドウ
    public GameObject result_window;  //リザルト画面用のウィンドウ
    int state_tmp = 0;          //現在のGameStateを参照
    int start_tmp;          //スタート
    int timeup_tmp;         //タイムアップ
    int result_tmp;         //リザルト
    public int state_pattern = 0;  //スタートとタイムアップの使い分け用
    int tmp_case = 0;       //３ケースの使い分け用


    // Use this for initialization
    void Start () {

        //MainManagerからGameStateを参照
        start_tmp = (int)MainManager.GameState.GAME_START;
        timeup_tmp = (int)MainManager.GameState.GAME_TIMEUP;
        result_tmp = (int)MainManager.GameState.GAME_RESULT;
    }
	
	// Update is called once per frame
	void Update () {

        //スタート、タイムアップ、リザルトを呼び出す
        state_tmp = (int)MainManager.CurrentState;

        if (tmp_case == 0 & state_tmp == start_tmp)
        {
            state_pattern = 0;
            State_Call();
            tmp_case = 1;
        }
        else if (tmp_case == 1 & state_tmp == timeup_tmp)
        {
            state_pattern = 1;
            State_Call();
            tmp_case = 2;
        }
        else if (tmp_case == 2 & state_tmp == result_tmp)
        {
            Result_Call();
            tmp_case = 0;
        }

        //infomationを呼び出す
        if ( Info_Case == InfoCase.INFO_TEST )
        {
            Debug.Log("ちくわ大明神");
            Info_Case = InfoCase.INFO_WAIT;
        }
        if (Info_Case == InfoCase.INFO_DAMAGE)
        {
            Debug.Log("石取られた");
            Info_Called();
            Info_Case = InfoCase.INFO_WAIT;
        }
        if (Info_Case == InfoCase.INFO_GET)
        {
            Debug.Log("石拾った");
            Info_Called();
            Info_Case = InfoCase.INFO_WAIT;
        }
    }

    void State_Call()   //スタート、タイムアップのウィンドウを呼び出す
    {
        // 生成
        Instantiate(state_window);        //呼び出すウィンドウ
    }

    void Result_Call()
    {
        Instantiate(result_window);     //呼び出すウィンドウ
    }

    void Info_Called()
    {
        Instantiate(called_window);     //呼び出すウィンドウ
    }

    public static void CallCase(InfoCase state)     //他スクリプトからのinfomation呼び出し用
    {
        Info_Case = state;
    }
}