using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_check : MonoBehaviour {

    [SerializeField]
    private GameObject r_hand;
    [SerializeField]
    private GameObject l_hand;

//    [SerializeField]
    public Vector3[] pos = new Vector3[2];
    public Vector3[] Hvelo = new Vector3[2];

    [SerializeField]
    public float[] handMag = new float[2];
    private Vector3[] latepos = new Vector3[2];
    // Use this for initialization
    void Start () {
        pos[0] = new Vector3();
        pos[1] = new Vector3();
    }

	// Update is called once per frame
	void Update () {
         pos[0] = r_hand.transform.position;
        pos[1] = l_hand.transform.position;
         Hvelo[0] = r_hand.GetComponent<cntl_test01>().velo;
        Hvelo[1] = l_hand.GetComponent<cntl_test01>().velo;

        for(int i = 0; i < 2; i++)
        {
            handMag[i] = ((pos[i] - latepos[i]) / Time.deltaTime).magnitude;
            latepos[i] = pos[i];
        }

    }
}
