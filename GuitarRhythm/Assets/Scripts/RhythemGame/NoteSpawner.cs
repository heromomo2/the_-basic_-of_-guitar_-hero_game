using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject m_NotePrefab = null; // object template of note
	[SerializeField]
	private Transform m_Target = null; 
	[SerializeField]
	private Transform m_OffScreen = null;

	private List<NoteMover> m_Notes = new List<NoteMover>(); // a list of notes spawned
	private List<NoteMover> m_RemoveList = new List<NoteMover>();  // a list of notes despawned




	public void UpdateNoteSpawner()
	{
		//  loop through list of list of notes spawn.
		foreach (NoteMover note in m_Notes) 
		{
			note.MoveUpdate ();

			if (note.transform.position.y < m_OffScreen.position.y) // note 
			{
				m_RemoveList.Add (note); // add notes to despawn list
			}
		}
		//  loop through list of list of notes despawn.
		foreach (NoteMover note in m_RemoveList)
		{
			m_Notes.Remove (note);
			note.ClaimNote ();
		}

		m_RemoveList.Clear ();
	}

	public void SpawnNote(float timeToTarget)
	{
		GameObject temp = Instantiate<GameObject> (m_NotePrefab);
		temp.transform.parent = this.transform;
		temp.transform.localPosition = Vector3.zero;

		NoteMover note = temp.GetComponent<NoteMover>();
		note.StartPosition = note.transform.position;
		note.Target = m_Target.position;
		note.TimeToTarget = timeToTarget;

		m_Notes.Add (note);

		Debug.Log(" SpawnNote is being calling");
	}

}
