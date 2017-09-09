using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotControl : MonoBehaviour {

    [SerializeField] private string name;
    public string Name { get { return name; } }

    private bool reached;
    public bool IsReached { get { return reached; } }

    public SpotControl(string str)
    {
        name = str;
    }

    private void OnTriggerEnter(Collider other)
    {
        reached = true;
        GetComponent<Collider>().enabled = false;
    }
}
