using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongData : Singleton<SongData> {
	
	private SongChart m_SelectSong; // SongChart

	public SongChart SelectSong {get {return m_SelectSong; } }  // create a getter from the songChart

	public void SongFilePath(string m_SongFilePath) // songname from the seleted song button
	{
		m_SelectSong = Resources.Load<SongChart> (m_SongFilePath); // Find in the path in the Resources folder
	}


}
