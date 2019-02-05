using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SongChart))]
public class SongChartEditor : Editor {

	private SongChart m_Song = null;

	private int m_NumOfRow = 0;

	void OnEnable()
	{
		m_Song = (SongChart)target;

//		for(int i = 0; i < m_Song.ListOfRows.Count; i++)
//		{
//			for(int j = 0 ; j < m_Song.NumOfCol; j++)
//			{
//
//				m_Song.ListOfRows[i].RowOfNote.Add(false);
//			}
//		}
	}

	[ContextMenu ("Reset")]
	private void Reset()
	{
		m_Song.ListOfRows.Clear ();
	}
		
	public override void OnInspectorGUI()
	{
		m_Song.Time = EditorGUILayout.FloatField ("Song lenth", m_Song.Time);

		m_Song.RowsPerMinute = EditorGUILayout.IntField ("Rows Per Minute", m_Song.RowsPerMinute);

		m_NumOfRow = (int)(m_Song.Time * (float)m_Song.RowsPerMinute) + 10;

//		if(m_NumOfRow < m_Song.ListOfRows.Count)
//		{
//			m_Song.ListOfRows.RemoveRange (m_NumOfRow,m_Song.ListOfRows.Count - m_NumOfRow);
//		}

		for(int i = 0; i < m_NumOfRow; i++)
		{
			
			if (i >= m_Song.ListOfRows.Count)
			{
				Row row = new Row ();
				row.AddToRows (m_Song.NumOfCol);
				m_Song.ListOfRows.Add (row );
			}
				
			EditorGUILayout.BeginHorizontal ();

			EditorGUILayout.LabelField ("Row " + i);

			for(int j = 0 ; j < m_Song.NumOfCol; j++)
			{

				m_Song.ListOfRows[i].RowOfNote[j]=EditorGUILayout.Toggle(m_Song.ListOfRows[i].RowOfNote[j]);
			}
			EditorGUILayout.EndHorizontal ();

		}

	}
}
