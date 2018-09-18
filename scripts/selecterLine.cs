using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selecterLine : MonoBehaviour {

    public TextMesh Nump;
    MusicPanelComponent Jm;
    float openTime = 0;
    public GameObject[] doar;
    bool JacEnter = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        if (doar[0].transform.localScale.x > 0.1f)
        {

            for (int i = 0; i < 4; i++)
            {
                doar[i].transform.localPosition += new Vector3(0.45f, 0, 0) * Time.deltaTime*5;
                doar[i].transform.localScale += new Vector3(-0.9f, 0, 0) * Time.deltaTime*5;
            }

        }else
        {
            for (int i = 0; i < 4; i++)
            {
                doar[i].transform.localPosition = new Vector3(-0.05f, 0, 0);
                doar[i].transform.localScale = new Vector3(0.1f, 2f, 0.1f);
            }
        }

        if (JacEnter)
        {
            openTime += Time.deltaTime;
            if (openTime >= 1f)
            {
                for (int i = 0; i < 4; i++)
                {
                    doar[i].transform.localPosition = new Vector3(-0.5f, 0, 0);
                    doar[i].transform.localScale = new Vector3(1f, 2f, 0.1f);
                }
                Nump.text = Jm.Jnum.ToString();
                JacEnter = false;
            }

        }else
        {
            openTime = 0;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (Jm = other.gameObject.GetComponent<MusicPanelComponent>())
        {
            JacEnter = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Jm = other.gameObject.GetComponent<MusicPanelComponent>())
        {
            JacEnter = false;
        }
    }
    /*
    private void OnTriggerStay(Collider other)
    {

        if(Jm = other.gameObject.GetComponent<MusicPanelComponent>())
        {
            for (int i = 0; i < 4; i++)
            {
                doar[i].transform.localPosition = new Vector3(-0.5f, 0, 0);
                doar[i].transform.localScale = new Vector3(1f, 2f, 0.1f);
            }
            Nump.text = Jm.Jnum.ToString();

        }

    }
    */
}
