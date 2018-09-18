using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPanelComponent : MonoBehaviour {

    public int Jnum;
    public GameObject Pon;

	// Use this for initialization
	void Start () {
        Pon.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        Pon.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Pon.SetActive(false);
    }
}
