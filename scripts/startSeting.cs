using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSeting : MonoBehaviour {
    public GameObject baseModel;

    public GameObject headLine;
    public GameObject[] bodyPart;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (headLine.transform.position.y >= 1f)
        {
            baseModel.transform.localScale = Vector3.Lerp(baseModel.transform.localScale,new Vector3(1.2f, 1.2f, 1.2f), Time.deltaTime * 10f);
/*
            foreach (GameObject bp in bodyPart)
            {
                bp.transform.localPosition = Vector3.zero;
            }
            bodyPart[0].transform.localRotation = Quaternion.Euler(0, -90, -100);
            bodyPart[1].transform.localRotation = Quaternion.Euler(0, 90, 0);
            bodyPart[2].transform.localRotation = Quaternion.Euler(0, -90, 0);
            */
        }
        else
        {
            baseModel.transform.localScale = Vector3.Lerp(baseModel.transform.localScale, new Vector3(0,1.2f,0), Time.deltaTime * 30f);
            if (baseModel.transform.localScale.x < 0.001f)
            {
                baseModel.transform.localScale = new Vector3(0, 1.2f, 0);
            }
            /*

            bodyPart[0].transform.rotation = Quaternion.Euler(0, -90, -90);
            
                        bodyPart[0].transform.position = new Vector3(0, 1.5f, -0.3f);
                        bodyPart[1].transform.position = new Vector3(0.3f, 1f, -0.3f);
                        bodyPart[2].transform.position = new Vector3(-0.3f, 1f, -0.3f);
            
            bodyPart[0].transform.position = Vector3.Lerp(bodyPart[0].transform.position, new Vector3(0, 1.5f, -0.3f), Time.deltaTime * 100f); ;
            bodyPart[1].transform.position = Vector3.Lerp(bodyPart[1].transform.position, new Vector3(0.3f, 1f, -0.3f), Time.deltaTime * 5f); ;
            bodyPart[2].transform.position = Vector3.Lerp(bodyPart[2].transform.position, new Vector3(-0.3f, 1f, -0.3f), Time.deltaTime * 5f); ;
            */
        }
    }
}
