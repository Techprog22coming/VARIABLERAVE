using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCount : MonoBehaviour {

	TextMesh T;
	// Use this for initialization
	void Start () {
		T = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		T.text = gameManage.comboCount.ToString("D2");
	}
}
