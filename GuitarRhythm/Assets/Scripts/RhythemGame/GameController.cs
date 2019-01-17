using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField]
	private string m_FilePath;

	[SerializeField]
	private List<NoteSpawner> m_Spawners; // list of spawners 

	[SerializeField]
	private MeunController m_MeunController;
	[SerializeField]
	private Transform m_Target;
	private float m_TargetDistance;

	private SongChart m_Song;
	private Timer m_SongTimer; //  Object from the timer class named M_ songTimer. 
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
		// If the timer isn't done then continue with what's happening in the curly brackets.
		if (!m_SongTimer.IsDone)  
		{	
			// Ask carlo to exaplain this to you.
			if (m_CurrentRow < m_Song.Rows.Count && m_SongTimer.CurrentTime > m_TimeStep * m_CurrentRow) 
		    {
				// Where you calling spawnNotes fuction beinng called.
				SpawnNotes (); 
				// increment the int m_CurrentRow.
				m_CurrentRow++;
			}
		}

		// loop through the list of Spawners depending on amount of spawners in the list.
		foreach (NoteSpawner spawner in m_Spawners) 
		{
			spawner.UpdateNoteSpawner ();
		}
	}

	// This is fuction  deal with  spawning notes. 
	private void SpawnNotes()
	{
		// loop around the same amount of times as there is spawners.
		for (int i = 0; i < m_Spawners.Count; i++) 
		{
			if (m_Song.Rows [m_CurrentRow][i] == '1') // 
			{
				// Display this "m_Song.Rows [m_CurrentRow][i]" in cosole.
				Debug.Log ("m_Song.Rows [m_CurrentRow][i]"+m_Song.Rows [m_CurrentRow][i]);
				//Figure out way to calculate the speed of the note to the target.
				m_Spawners[i].SpawnNote (m_TargetDistance * m_TimeStep); 
			}
		}
	}

	private void SetUpKeys()
	{
		/*  Connectioning to Fuctions in this class to the delegate event in InputController class.
		 *  When the delegate event is being call the fuctions connnected to will also being call.
		*/
	 	InputController.Instance.OnPressCenterString += HitCenterKey;
	 	InputController.Instance.OnPressRightString += HitRightKey;
	 	InputController.Instance.OnPressLeftString += HitLeftKey;
		InputController.Instance.OnPressGameMenu += HitGameMenuKey;
	}

	private void OnDestroy()
	{
		// if InputController class is an Instance and not null then continue with code in curly brackets.
		if (!InputController.IsInstanceNull) 
		{
			/*Makes sure to break the connection between delegates events and then functions subscribe to the delegates 
			 * if the class is destroyed.
			*/
			InputController.Instance.OnPressCenterString -= HitCenterKey;
			InputController.Instance.OnPressRightString -= HitRightKey;
			InputController.Instance.OnPressLeftString -= HitLeftKey;
			InputController.Instance.OnPressGameMenu -= HitGameMenuKey;
		}
	}
	/// <summary>
	/// Hits the key.
	/// print to the cosole.
	/// </summary>
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
