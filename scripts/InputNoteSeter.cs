using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class InputNoteSeter : MonoBehaviour {
	float putTime;
    public bool Lv1, Lv2, Lv3;

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f,1f,1f,0.8f);
        Gizmos.DrawCube(transform.position, new Vector3(0.3f, 0.3f, 0.3f));

//		Gizmos.DrawCube(transform.position, new Vector3(4f, 4f, 4f));
    }
#endif

    void Start () {
        putTime = transform.position.z / 10f * (60f / gameManage.BPM);
	}

	void Update () {

        if (gameManage.gameTime >= putTime - 1.5f)
        {
            Instantiate((GameObject)Resources.Load("Prefabs/PenNote"), new Vector3(transform.position.x, transform.position.y, 15), Quaternion.identity);

            Destroy(gameObject);

            //ノートオブジェクトを設置し自分はデストロイ

            //必要ならばここの処理でノート出現のエフェクトを出す処理も行う
            //全体の細かい演出はアニメーターで作る予定だからあまり細かく指定する必要はないはず
        }
        
        
	}
#if UNITY_EDITOR
    [CustomEditor(typeof(InputNoteSeter))]

    public class EditPointXY : Editor
    {
        private InputNoteSeter InputPos;

        private void OnEnable()
        {
            InputPos = (InputNoteSeter)target;
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            EditorGUILayout.BeginVertical();
            for (int y = 0; y < 5; y++)
            {
                EditorGUILayout.BeginHorizontal();

                for (int x = 0; x < 7; x++)
                {
                    if (GUILayout.Button("X"))
                    {
						InputPos.transform.localPosition = new Vector3(x * 0.3f - 0.9f, y * -0.3f + 0.6f+1.5f, InputPos.transform.localPosition.z);
                    }
                }

                EditorGUILayout.EndHorizontal();
            }
			EditorGUILayout.BeginHorizontal();
			for (int x = 0; x < 7; x++)
			{
				if (GUILayout.Button(""+(x-3)))
				{
					InputPos.transform.localPosition += new Vector3(0, 0,-30 +10*x);
				}

			}
			EditorGUILayout.EndHorizontal();

			if (GUILayout.Button("Do"))
			{
				GameObject toNote =	Instantiate((GameObject)Resources.Load("Prefabs/SetNote"),InputPos.transform.position+ new Vector3(0, 0, 10), Quaternion.identity);

				toNote.transform.parent = InputPos.transform.root.transform;
				Selection.activeObject = toNote;

			}
            EditorGUILayout.EndVertical();
        }
        
    }
#endif
}
