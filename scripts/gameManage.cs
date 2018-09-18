using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameManage : MonoBehaviour {

	public static float BPM = 155; //音楽のスピード
	public static float Speed = 3;//譜面が流れるスピード

	public static int comboCount=0;

    public float debugTime;
    AudioSource music;


    public float endTime;

    public Animator mainAnim;
	public static float gameTime = 0;//ゲームスタートからの時間を測るタイマー:これで判定を測る

    private GameObject FinishTxt;
    public Image fade;

    List <Vector3> notePos = new List<Vector3>();

/*
	public struct NoteData
	{
		public Vector3 Pos;     //ノーツのラインの位置
		public int Type;    //ノーツの種類　特殊な操作を要求するノーツを追加予定だったり
		public float Head;  //ノーツの先頭の位置
		public float Long;  //ノーツの長さ

		public NoteData(Vector3 P,int T,float H,float L){
			Pos = P;
			Type = T;
			Head = H;
			Long = L;
		}
	}
	private List<NoteData> noteData = new List<NoteData> ();
*/
	// Use this for initialization
	void Start () {
        transform.localScale = Vector3.one;
        music = GetComponent<AudioSource>();

		Speed = 3;
		BPM = 155;
        comboCount = 0;

        music.time = debugTime;
        gameTime = debugTime;
    }

	// Update is called once per frame
	void Update () {
		gameTime += Time.deltaTime;



        if (gameTime+10 >= endTime)
        {
            if(FinishTxt == null)
            {
                FinishTxt = Instantiate((GameObject)Resources.Load("Prefabs/endText"), new Vector3(0, 1.518f, 1.84f), Quaternion.identity);
            }else
            {

            }


        }


        if (gameTime >= endTime)
        {
            fade.color += new Color(0, 0, 0, Time.deltaTime);
            if (fade.color.a >= 1) { SceneManager.LoadScene("selectGame"); }

        }else if (Input.GetButton("Fire1") || Input.GetButton("Cancel"))
        {
            fade.color += new Color(0, 0, 0, Time.deltaTime);
            if (fade.color.a >= 1) { SceneManager.LoadScene("selectGame"); }
        }
        else
        {
            fade.color = new Color(0, 0, 0, 0);
        }
        //		note.transform.position += new Vector3 (0, 0, Time.deltaTime * Speed*-10);
    }
}