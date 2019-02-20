using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Row {

	[SerializeField]
	private List<bool> m_RowOfNote = new List<bool>();


	[SerializeField]
	private List<float> m_TimeSignature; 


	public List<bool>RowOfNote
	{
		get {return m_RowOfNote; }
	}

	public List<float> TimeSignature
	{
		get {return m_TimeSignature; }
	}
		
	public void AddToRows(int NumOfCol)
	{
		m_RowOfNote.Clear();

		for(int i = 0; i < NumOfCol ; i++)
		{
			m_RowOfNote.Add (false);
		}
	}
}
