using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKey( KeyCode.LeftArrow ) ) {
            gameObject.transform.Rotate( 0, -0.5f, 0, Space.World );
        }
        if ( Input.GetKey( KeyCode.RightArrow ) ) {
            gameObject.transform.Rotate( 0, 0.5f, 0, Space.World );
        }
    }
}
