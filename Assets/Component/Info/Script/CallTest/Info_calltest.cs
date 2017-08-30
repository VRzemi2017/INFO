using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_calltest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            /*
             * ウィンドウを出したいタイミングでこの三行を追加する
            GameObject infoMgr = GameObject.Find("Info_Mgr");        //Info_Mgrを探す
            info_mgr1 call = infoMgr.GetComponent<info_mgr1>();
            call.Info_callWin();
            */
        }
    }
}
