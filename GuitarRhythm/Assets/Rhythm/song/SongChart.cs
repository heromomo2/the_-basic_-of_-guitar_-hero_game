using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New", menuName ="RythmGame/Song", order = 1)]
public class SongChart : ScriptableObject {

	[SerializeField] 
	private List <string> m_Row = new List<string> ();


	public List<string>Rows
	{
		get {return m_Row; }
	}

	private void Awake(){
		m_Row.Reverse ();
	}

}
