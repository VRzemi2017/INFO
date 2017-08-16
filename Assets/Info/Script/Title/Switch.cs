using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour {
    //public GameObject text;             //表示するテキスト
    public TextMesh stringTextMesh;     //表示するテキスト
    int state = 0;                      //0：準備中　1：準備完了

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown( KeyCode.S ) ) {
            state = 1;
        }
        UpdateText( );

        if ( state == 1 & Input.GetKeyDown( KeyCode.KeypadEnter ) ) {
            SceneManager.LoadScene( "Sence" );
        }
	}

    void UpdateText( ) {    //テキストの中身
        if ( state == 0 ) {
            stringTextMesh.text = "待機中";
        } else if ( state == 1 ) {
            stringTextMesh.text = "準備完了";
        }        
    }
}
