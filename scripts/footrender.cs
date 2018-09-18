using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footrender : MonoBehaviour {
    public GameObject rootP;
    public bool overL, overR;
    public float Xmag=1, Zmag=5,Omag=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 AnsVec = new Vector3(rootP.transform.position.x/Xmag, 0, rootP.transform.position.z/Zmag);
        if (!overL && AnsVec.x > 0) AnsVec = new Vector3(rootP.transform.position.x / Omag, 0, rootP.transform.position.z);
        if (!overR && AnsVec.x < 0) AnsVec = new Vector3(rootP.transform.position.x / Omag, 0, rootP.transform.position.z);

        transform.position = AnsVec;
        /*

        transform.localPosition = new Vector3(rootP.transform.position.x / Xmag, 0, rootP.transform.position.z / Zmag+0.1f);
        if (!overL && transform.localPosition.x > 0) transform.localPosition = new Vector3(transform.localPosition.x / Omag, 0, transform.localPosition.z);
        if (!overR && transform.localPosition.x < 0) transform.localPosition = new Vector3(transform.localPosition.x / Omag, 0, transform.localPosition.z);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
*/
    }
}
