﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDstroy : MonoBehaviour {
	float con =0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		con += Time.deltaTime;
		if (con >= 1)
			Destroy (gameObject);
	}
}
