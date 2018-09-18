using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantParent : MonoBehaviour {
    public GameObject pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = pos.transform.position;
	}
}
