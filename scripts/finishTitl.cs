using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishTitl : MonoBehaviour {
    public TextMesh rezlt;
    float timmer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timmer += Time.deltaTime;
        if (transform.localScale.y < 1) {
            transform.localScale += new Vector3(0, 1, 0) * Time.deltaTime *3f;
        }else
        {
            transform.localScale = Vector3.one;
        }
        if (timmer >= 1)
        {
            rezlt.text = "RESULT : "+gameManage.comboCount;
        }

	}
}
