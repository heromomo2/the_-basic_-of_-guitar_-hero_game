using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSong", menuName ="RhythmGame/Song", order = 1)]
public class SongChart : ScriptableObject {
	
	[SerializeField] 
	private List <Row> m_Rows = new List<Row> ();

	[SerializeField]
	private float m_Time = 0;

	[SerializeField]
	private int m_NumOfCol = 3;

	public float Time
	{
		get {return m_Time;}
	}

	public int NumOfCol
	{
		get {return m_NumOfCol;}
	}
		

	public List<Row > GetRows
	{
		get { return m_Rows; }
	}


   [ContextMenu ("Reverse Rows")]
	private void Reverse()
	{
		m_Rows.Reverse ();
	}

	#if UNITY_EDITOR

	public List<Row> ListOfRows 
	{
		get{return m_Rows;}
		set{ m_Rows = value;}
	}

	public void InitalizeEditor ()
	{
		if(m_Rows.Count == 0)
		{
			
		}
		
	}
	#endif
}
