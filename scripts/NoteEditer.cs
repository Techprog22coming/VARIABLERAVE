using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

public class NoteEditer : MonoBehaviour {

	public float[] BPM;

	private List<Vector3> NotePos = new List<Vector3>();

	public int NoteCount()
	{
		return NotePos.Count;
	}
/*
	

	[CustomEditor (typeof(NoteEditer))]

	public class NoteEdit : Editor
	{

		private ReorderableList NotePoint;

		private NoteEditer note{
			get{
				return target as NoteEditer;
			}
		}

		

		private void OnEnable(){
			NotePoint = new ReorderableList (serializedObject, serializedObject.FindProperty ("NotePos"));
			NotePoint.onAddCallback += AddBPM;
			NotePoint.onRemoveCallback += RemoveBPM;
		}

		public override void OnInspectorGUI(){
			DrawDefaultInspector ();
			serializedObject.Update ();
			NotePoint.DoLayoutList ();
			serializedObject.ApplyModifiedProperties ();

		}

		private void AddBPM(ReorderableList list){
			note.NotePos.Add (new Vector3(0,0,0));
		}
		private void RemoveBPM(ReorderableList list){
			note.NotePos.RemoveAt (note.NotePos.Count - 1);
		}
	}
*/
}
