using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongData : Singleton<SongData> {
	
	private SongChart m_SelectSong;

	public SongChart SelectSong {get {return m_SelectSong; } }
	public void SongFilePath(string m_SongFilePath)
	{
		m_SelectSong = Resources.Load<SongChart> (m_SongFilePath);
	}


}
