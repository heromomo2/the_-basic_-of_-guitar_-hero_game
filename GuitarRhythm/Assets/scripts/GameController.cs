using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField]
	private string m_FilePath;

	private SongChart m_Song;
	private Timer m_SongTimer;
	private float m_TimeStep = 0;
	private int m_CurrentRow = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void Initialize ()
	{
		m_Song = Resources.Load<SongChart> (m_FilePath);

		if (m_Song == null)
		{
			Debug.LogError ("NO SONG FOUNG DUMMY! ");
			return;
		}
		m_SongTimer = new Timer (m_Song.Time);
		m_TimeStep = m_Song.Time / m_Song.Rows.Count;
		m_CurrentRow = 0;

		m_SongTimer.m_OnUpdate += UpdateSong;
		
	}
	[ContextMenu("Start Song")]
	private void StartSong()
	{
		m_SongTimer.Start ();
	}

	private void UpdateSong()
	{
		Debug.Log (m_SongTimer.CurrentTime);
		if (m_CurrentRow < m_Song.Rows.Count && m_SongTimer.CurrentTime > m_TimeStep * m_CurrentRow) {
			SpawnNotes ();
			m_CurrentRow++;
		
		}
	}

	private void SpawnNotes()
	{
		Debug.LogWarning (m_Song.Rows[m_CurrentRow]);

		// TODO: Parse string to spawn notes properly here.
	}
}
