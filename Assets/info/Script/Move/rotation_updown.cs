using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_updown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKey( KeyCode.UpArrow ) ) {
            gameObject.transform.Rotate( -0.5f, 0, 0, Space.World );
        }
        if ( Input.GetKey( KeyCode.DownArrow ) ) {
            gameObject.transform.Rotate( 0.5f, 0, 0, Space.World );
        }
    }
}
