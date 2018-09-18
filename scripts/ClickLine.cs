using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLine : MonoBehaviour {
    bool nobiru = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, 10) * Time.deltaTime;
        if (!nobiru)
        {
            transform.localScale += new Vector3(0, 0, 20) * Time.deltaTime;
            if (transform.localScale.z >= 10) nobiru = true;
        }else
        {
            transform.localScale -= new Vector3(0, 0, 20) * Time.deltaTime;
            if (transform.localScale.z <= 0) nobiru = false;
        }
    }
}
