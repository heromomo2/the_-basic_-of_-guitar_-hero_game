﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField]
	private string m_FilePath;

	[SerializeField]
	private List<NoteSpawner> m_Spawners;

	[SerializeField]
	private MeunController m_MeunController;
	[SerializeField]
	private Transform m_Target;
	private float m_TargetDistance;

	private SongChart m_Song;
	private Timer m_SongTimer;
	private float m_TimeStep = 0;
	private int m_CurrentRow = 0;
	//private SongData m_SeletedSond;


	// Use this for initialization
	void Start () 
	{
		Initialize ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_SongTimer != null) 
		{
			m_SongTimer.Update ();
			UpdateSong ();
		}
	}

	private void Initialize ()
	{
		//m_Song = Resources.Load<SongChart> (m_FilePath);
		m_Song = SongData.Instance.SelectSong;
		if (m_Song == null)
		{
			Debug.LogError ("NO SONG FOUNG DUMMY! ");
			return;
		}

		m_SongTimer = new Timer (m_Song.Time);
		m_TimeStep = m_Song.Time / m_Song.Rows.Count;
		m_CurrentRow = 0;

		m_TargetDistance = Vector3.Distance (m_Spawners[0].transform.position, m_Target.position);

		SetUpKeys ();
	}

	//[ContextMenu("Start Song")]
	public void StartSong()
	{
		m_SongTimer.Start ();
	}

	private void UpdateSong()
	{
		if (!m_SongTimer.IsDone) 
		{	
			if (m_CurrentRow < m_Song.Rows.Count && m_SongTimer.CurrentTime > m_TimeStep * m_CurrentRow) 
		    {
				SpawnNotes ();
				m_CurrentRow++;
			}
		}

		foreach (NoteSpawner spawner in m_Spawners) 
		{
			spawner.UpdateNoteSpawner ();
		}
	}

	private void SpawnNotes()
	{
		for (int i = 0; i < m_Spawners.Count; i++)
		{
			if (m_Song.Rows [m_CurrentRow][i] == '1')
			{
				Debug.Log ("m_Song.Rows [m_CurrentRow][i]"+m_Song.Rows [m_CurrentRow][i]);
				m_Spawners[i].SpawnNote (m_TargetDistance * m_TimeStep); //Figure out way to calculate the speed of the note to the  target
			}
		}
	}

	private void SetUpKeys()
	{
	 	InputController.Instance.OnPressCenterString += HitCenterKey;
	 	InputController.Instance.OnPressRightString += HitRightKey;
	 	InputController.Instance.OnPressLeftString += HitLeftKey;
		InputController.Instance.OnPressGameMenu += HitGameMenuKey;
	}

	private void OnDestroy()
	{
		if (!InputController.IsInstanceNull) 
		{
			InputController.Instance.OnPressCenterString -= HitCenterKey;
			InputController.Instance.OnPressRightString -= HitRightKey;
			InputController.Instance.OnPressLeftString -= HitLeftKey;
		}
	}
	private void HitGameMenuKey () 
	{
		Debug.Log ("GameMenuKey was pressed");
		m_MeunController.OpenGameMenu ();
	}
	private void HitCenterKey () 
	{
		Debug.Log ("Centerkey was pressed");
	}

	private void HitRightKey () 
	{
		Debug.Log ("RightKey was pressed");
	}

	private void HitLeftKey () 
	{
		Debug.Log ("LeftKey was pressed");
	}
}
