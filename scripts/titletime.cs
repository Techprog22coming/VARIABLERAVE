using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titletime : MonoBehaviour {
    float timeer = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        timeer += Time.deltaTime;
        transform.position += new Vector3(0, 0, 0.3f) * Time.deltaTime;
        if (timeer >= 5)
        {
            if(transform.localScale.y>0.01)
            {

                transform.localScale -= new Vector3(0, 15, 0) * Time.deltaTime;
            }else
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.01f, 1);
                transform.localScale -= new Vector3(15, 0, 0) * Time.deltaTime;
            }
			if (transform.localScale.x <= 0) Destroy(gameObject);

        }
	}
}
