using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleStart : MonoBehaviour {
    public LineRenderer Lr;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0, 0,1f * Time.deltaTime);
        transform.localScale += new Vector3(0.6f, 0.6f, 0) * Time.deltaTime;
        if (gameManage.gameTime >= 5)
        {
            Lr.startColor -= new Color(0, 0, 0, 1) * Time.deltaTime;
            Lr.endColor -= new Color(0, 0, 0, 1) * Time.deltaTime;
            if (Lr.startColor.a <= 0)
            {
                Destroy(gameObject);
            }
        }
	}
}
