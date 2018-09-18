using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIfadeout : MonoBehaviour {
	Image fade;
	// Use this for initialization
	void Start () {
		fade= GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		fade.color += new Color (0, 0, 0, -Time.deltaTime);
	}
}
