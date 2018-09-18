using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cntl_test01 : MonoBehaviour {
    
    [SerializeField]
    private Vector3 pre_pos;

    [SerializeField]
    public Vector3 velo;

    public bool testfil;

    public float punch, srash;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //速度を求める。
       
        velo = (pre_pos - transform.position)*30f;

        Debug.DrawLine(transform.position, transform.position - velo, Color.yellow);
        if (testfil)
        {
            if (new Vector3(velo.x, velo.y, 0).magnitude > srash)
            {

            }
            else
            {

            }

            if (velo.z <= -punch)
            {
                //           testeer.SetActive(true);
                //           testeer.transform.localScale = new Vector3(1, velo.z, 1);
            }
            else
            {
                //            testeer.SetActive(false);
            }

            if (velo.magnitude > srash)
            {
            }
            else
            {
            }
        }
        //現在の座標を保存
        pre_pos = transform.position;
	}
}
