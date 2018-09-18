using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjct : MonoBehaviour {

    public bool onPos;

	public float timePoint;
	GameObject ConPos;
    hand_check conData;

    Vector3 Finpos;
    float enX;
	bool justOn = false;
    bool clearE = false;
    bool clearB = false;
    Quaternion paraQ;

	// Use this for initialization
	void Start () {
		timePoint = transform.position.z / 10f / gameManage.Speed;
        ConPos = GameObject.Find("hand_check");
        conData = ConPos.GetComponent<hand_check>();
        Finpos= new Vector3(transform.position.x / 1.5f, transform.position.y, 0);
        enX =  transform.position.x - Finpos.x ;
//        transform.LookAt(Finpos);
    }

	// Update is called once per frame
	void Update () {


        transform.position += new Vector3(0, 0, -10 * Time.deltaTime);

        if (Finpos.x != transform.position.x)
        {
            transform.position += new Vector3(transform.position.x - Finpos.x, 0, 0) * -Time.deltaTime*1.2f;
        }

        if (onPos)
        {



            if (!justOn && transform.position.z<=8)
            {
                //GameObject Pa = Instantiate((GameObject)Resources.Load("Prefabs/box2"), new Vector3(transform.position.x, transform.position.y, -1f), transform.rotation);
//                GameObject Pa = Instantiate((GameObject)Resources.Load("Prefabs/box2"), new Vector3(Finpos.x, Finpos.y, 0), transform.rotation);
//                Instantiate((GameObject)Resources.Load("Prefabs/linePan"), transform.position, transform.rotation);

                justOn = true;
            }else {
                //pointLine.SetPosition(1, transform.position);
            }
            //  if(justOn) pointLine.SetPosition(1, new Vector3(0, 0.6f, -1f));


            if (transform.position.z <= 3.0 && transform.position.z >= -0.2)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    clearE = true;

                }

                for (int i = 0; i < 2; i++)
                {

                    /*                    if (Vector3.Distance(new Vector3(conData.pos[i].x, conData.pos[i].y, 0),
                                            new Vector3(transform.position.x, transform.position.y, 0))
                                            <= 0.3)*/

//                    if (Vector3.Distance(conData.pos[i],transform.position) <= 0.3)
                    if (Vector3.Distance(conData.pos[i] + conData.Hvelo[i] /-2f, transform.position) <= conData.Hvelo[i].magnitude /1.5f || Vector3.Distance(conData.pos[i], transform.position)<=0.5f)
                        {

                        //

      //                  GameObject cObj = Instantiate((GameObject)Resources.Load("Prefabs/clearPa"), transform.position, Quaternion.LookRotation(Vector3.zero, conData.Hvelo[i]));
                        //                        GameObject cObj = Instantiate((GameObject)Resources.Load("Prefabs/clearPa"), transform.position, Quaternion.LookRotation(Vector3.zero,conData.Hvelo[i]));
                        //                        Debug.Log("ベクトル"+conData.Hvelo[i]+" 向き"+ Quaternion.LookRotation(Vector3.zero, conData.Hvelo[i]));
                        clearE = true;
                        if(conData.Hvelo[i].magnitude > 1.4f) {
                            clearB = true;
                            paraQ = Quaternion.LookRotation(conData.pos[i], conData.pos[i]-conData.Hvelo[i]);
                        }
                        
                        break;
                        //                        Debug.Log("con " + ConPos[i].transform.position + " note " + transform.position);
                    }
                }
            }
            else if (transform.position.z < -0.2)
            {
                transform.position += new Vector3(0, -0.03f, 0.1f);
                if (transform.position.z < -10) Destroy(gameObject);
            }
            if (transform.position.z <= 0&& clearE)
            {

//                Instantiate((GameObject)Resources.Load("Prefabs/clearPa"), transform.position, Quaternion.identity);
                if (clearB)
                {
                    Instantiate((GameObject)Resources.Load("Prefabs/clearB"), transform.position,Quaternion.Slerp( Quaternion.identity, paraQ,0.2f));
//                    Instantiate((GameObject)Resources.Load("Prefabs/hundthunder"), transform.position, Quaternion.Slerp(Quaternion.identity, paraQ, 0.2f));
                }
                else
                {
                    Instantiate((GameObject)Resources.Load("Prefabs/clearN"), transform.position, Quaternion.identity);
                }
				gameManage.comboCount++;
                Destroy(gameObject);
            }
            }

	}
}
