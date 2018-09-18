using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRender : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        if (transform.localScale.x < 0.3)
        {
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f) * Time.deltaTime * 2;
        }else
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        }
}
