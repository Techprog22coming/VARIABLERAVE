using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectGage : MonoBehaviour {

    public Image gage;


    float ten;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        ten += Time.deltaTime;
        if (ten > 1)
        {
            ten = 1;
        }
        gage.rectTransform.sizeDelta=new Vector2(ten,0.1f);
	}

    private void OnDisable()
    {
        ten = 0;
    }
}
