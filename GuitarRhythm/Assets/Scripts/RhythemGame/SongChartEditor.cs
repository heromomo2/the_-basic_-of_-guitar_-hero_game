using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SongChart))]
public class SongChartEditor : Editor {

	private SongChart m_Song = null; // m_song is null and object from the SongChart class 

	private int m_NumOfRow = 0;  // number of row and is a an int.

	void OnEnable()
	{
		m_Song = (SongChart)target; // (Explicit casting)casting m_Song

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
		if ( m_Song != null)
		{
			m_Song.ListOfRows.Clear ();
		}
	}
		
	public override void OnInspectorGUI()
	{
		m_Song.Time = EditorGUILayout.FloatField ("Song lenth", m_Song.Time); // you can input value in the inspector.

		m_Song.RowsPerMinute = EditorGUILayout.IntField ("Rows Per Minute", m_Song.RowsPerMinute);  // you can input value in the inspector.

		m_NumOfRow = (int)(m_Song.Time * (float)m_Song.RowsPerMinute) + 10; // ask carlo about this piece of code

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
