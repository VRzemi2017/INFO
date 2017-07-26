using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class img_point : MonoBehaviour {
    GameObject Mgr;
	// Use this for initialization
	void Start () {
        Mgr = GameObject.Find( "Info_Mgr" );
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Mgr.transform.position;
        transform.rotation = Mgr.transform.rotation;
    }
}
