using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSong", menuName ="RhythmGame/Song", order = 1)]
public class SongChart : ScriptableObject {
	/// <summary>
	/// The m rows .
	/// </summary>
	[SerializeField] 
	private List <Row> m_Rows = new List<Row> ();
	/// <summary>
	/// The m time is the length of the song.
	/// </summary>
	[SerializeField]
	private float m_Time = 0; /// <summary>
	/// The m number of col.
	/// </summary>

	[SerializeField]
	private int m_NumOfCol = 3;  // m

	private int m_RowsPerMinute = 0;

//	[SerializeField]
//	private List <float> m_SongChartTimeSignature; 
//
//
//	public List <float> SongChartTimeSignature
//	{
//		get {return m_SongChartTimeSignature;}
//		set {m_SongChartTimeSignature = value;}
//	}

	public float Time
	{
		get {return m_Time;}
		set {m_Time = value;}
	}

	public int RowsPerMinute
	{
		get {return m_RowsPerMinute;}
		set {m_RowsPerMinute = value;}
	}

	public int NumOfCol
	{
		get {return m_NumOfCol;}
	}
		
	public List<Row> GetRows
	{
		get { return m_Rows; }
	}
		
   [ContextMenu ("Reverse Rows")]
	private void Reverse()
	{
		m_Rows.Reverse ();
	}
	/*
	 * Code for the SongChartEditor.
	 * don't touch it.
	*/
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
