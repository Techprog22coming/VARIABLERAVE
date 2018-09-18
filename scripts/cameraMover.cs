using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMover : MonoBehaviour {

    public GameObject playerM;

    public float[] changtime;
    public Transform[] points;
    public Transform[] lockpoints;
    float camTime=0;

    private int Cpoint;
	// Use this for initialization
	void Start () {
        Cpoint = 0;
        transform.position = points[Cpoint].position;
        transform.rotation = points[Cpoint].rotation;
    }

	// Update is called once per frame
	void Update () {
        camTime += Time.deltaTime;
        if (changtime[Cpoint]<=camTime)
        {
            Cpoint++;
            if (Cpoint >= points.Length)
            {
                Cpoint = 0;
                camTime = 0;
            }

            //            Debug.Log(Input.GetJoystickNames());
            //            transform.position += new Vector3(0.05f, 0, 0);
        }

        transform.position = Vector3.Lerp(transform.position, points[Cpoint].position + playerM.transform.position, Time.deltaTime * 5f);
        //        transform.position = points[Cpoint].position+playerM.transform.position;

        if (lockpoints[Cpoint] != null)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(lockpoints[Cpoint].position-transform.position), Time.deltaTime * 5f);
        }else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, points[Cpoint].rotation, Time.deltaTime * 5f);
        }

//        transform.rotation = points[Cpoint].rotation;
    }
}
