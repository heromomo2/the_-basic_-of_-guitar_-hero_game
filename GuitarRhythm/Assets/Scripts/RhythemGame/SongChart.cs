using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSong", menuName ="RhythmGame/Song", order = 1)]
public class SongChart : ScriptableObject {

	[SerializeField] 
	private List <string> m_Row = new List<string> ();

	[SerializeField]
	private float m_Time = 0;

	public List<string>Rows
	{
		get {return m_Row; }
	}


	public float Time
	{
		get {return m_Time;}
	}


   [ContextMenu ("Reverse Rows")]
	private void Reverse()
	{
		m_Row.Reverse ();
	}


}
