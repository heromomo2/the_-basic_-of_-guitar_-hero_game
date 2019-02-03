using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SongChart))]
public class SongChartEditor : Editor {

	private SongChart m_Song = null;

	void OnEnable()
	{
		m_Song = (SongChart)target;

		for(int i = 0; i < m_Song.ListOfRows.Count; i++)
		{
			for(int j = 0 ; j < m_Song.NumOfCol; j++)
			{

				m_Song.ListOfRows[i].RowOfNote.Add(false);
			}
		}
	}
		
	public override void OnInspectorGUI()
	{
		//EditorGUILayout.BeginHorizontal ();

		for(int i = 0; i < m_Song.ListOfRows.Count; i++)
		{
			EditorGUILayout.BeginHorizontal ();
			for(int j = 0 ; j < m_Song.NumOfCol; j++)
			{

				m_Song.ListOfRows[i].RowOfNote[j]=EditorGUILayout.Toggle(m_Song.ListOfRows[i].RowOfNote[j]);
			}
			EditorGUILayout.EndHorizontal ();

		}

	}
}
