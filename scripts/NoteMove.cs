using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, -10 * Time.deltaTime);
		if (transform.position.z <= -10) {
			Destroy (gameObject);
		}
	}
}
