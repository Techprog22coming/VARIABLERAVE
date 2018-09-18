using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameJunp : MonoBehaviour {

    private AsyncOperation srt;
    bool jupmA;

    bool toTall;
    float timer = 0;


    public GameObject playTall;
    public GameObject[] hand;

    public Image gameTm;
    public GameObject stFX;
	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        toTall = false;
        timer = -1;
	}

	// Update is called once per frame
	void Update () {

        if (playTall.transform.position.y < 1)
        {
            toTall = true;
        }

        if (playTall.transform.position.y > 1 && toTall)
        {
            stFX.transform.localScale = Vector3.Lerp(stFX.transform.localScale, Vector3.one, Time.deltaTime * 5f);
            for (int i = 0; i < 2; i++)
            {
                if (hand[i].GetComponent<cntl_test01>().velo.magnitude >4)
                {
                    if (srt == null&&timer>0.01f)
                    {
                        Debug.Log("power");
                        StartCoroutine("startScene");
                    }
                }
                if (Vector3.Distance(hand[i].transform.position, transform.position) <= 0.4)
                {
                    jupmA = true;
                }
            }
        }else
        {
            stFX.transform.localScale = Vector3.Lerp(stFX.transform.localScale, Vector3.zero, Time.deltaTime * 5f);
        }

        if (jupmA)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                if (srt == null)
                {
                    StartCoroutine("startScene");
                }


            }
        }
        else
        {
            timer = 0;
        }

        gameTm.fillAmount = timer / 2f;

        jupmA = Input.GetButton("Fire1");

    }

    IEnumerator startScene()
    {

        // シーンの読み込みをする
        srt = SceneManager.LoadSceneAsync("MainGame");

        //　読み込みが終わるまで進捗状況をスライダーの値に反映させる
        while (!srt.isDone)
        {
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        jupmA = true;
    }

    private void OnTriggerExit(Collider other)
    {
        jupmA = false;
		Debug.Log (other);
    }
}
